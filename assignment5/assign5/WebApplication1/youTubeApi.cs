using Google.Apis.YouTube.v3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;


namespace WebApplication1
{
    /// <summary>
    /// this is the api that access the youtube page and allows searching of their app
    /// the json file has been included with the oauth details 
    /// </summary>
    public class youTubeApi
    {
        //create a service object for authentication
        private static YouTubeService ytService = Auth();


        private static YouTubeService Auth()
        {
            //get the credentials from the json file that was added 
            UserCredential credentials;
            using (var stream = new FileStream(HttpRuntime.AppDomainAppPath + "youtube_client_secret.json", FileMode.Open, FileAccess.Read))
            {
                //assign the credentails and assign the json to an object that can be used
                credentials = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[]
                    {
                        YouTubeService.Scope.YoutubeReadonly
                    },
                    "user",
                    CancellationToken.None, new FileDataStore("YouTubeAPI")).Result;
            }

            //intialize the service that will be the interfacing mechanism
            //set up authentication as well
            var service = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credentials,
                ApplicationName = "YouTubeAPI"
            });

            return service;
        }

        /// <summary>
        /// assigns the video description ect
        /// </summary>
        /// <param name="video"> the video requested</param>
        public static void GetVideoInfo(YouTubeVideo video)
        {
            //the video request
            var request = ytService.Videos.List("snippet");
            request.Id = video.id;

            //execute the response to get the information desired
            var response = request.Execute();

            //set the title and description
            video.title = response.Items[0].Snippet.Title;
            video.description = response.Items[0].Snippet.Description;


        }
    }
}