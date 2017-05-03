using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace Google.Apis.YouTube.Samples
{
    /// <summary>
    /// this is based off of the youtube api documentation work page
    /// it access the acount information and displays videos uploaded
    /// one video will be shown the rest will not be displayed please do not 
    /// upload videos to my account
    /// </summary>
    internal class MyUploads
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Accessing account information to display uploads");
            Console.WriteLine();
            Console.WriteLine();

            //start the display process
            try
            {
                new MyUploads().Run().Wait();
            }
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }

            Console.WriteLine("all uploads displayed press enter to terminate");
            Console.ReadKey();
        }

        private async Task Run()
        {
            UserCredential credential;

            //take the oauth and api keys from the json file to validate proper privilidges to access account
            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {

                    //allow access to view the video
                    credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { YouTubeService.Scope.YoutubeReadonly },
                    "user",
                    CancellationToken.None,
                    new FileDataStore(this.GetType().ToString())
                );
            }

            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                //intialize the service that will be the interfacing mechanism
                //set up authentication as well
                HttpClientInitializer = credential,
                ApplicationName = this.GetType().ToString()
            });

            var channelsListRequest = youtubeService.Channels.List("contentDetails");
            channelsListRequest.Mine = true;

            //get the contentDetails part of the channel 
            var channelsListResponse = await channelsListRequest.ExecuteAsync();

            foreach (var channel in channelsListResponse.Items)
            {
               
                var uploadsListId = channel.ContentDetails.RelatedPlaylists.Uploads;

                Console.WriteLine("The videos availabel are {0}", uploadsListId);

                var nextPageToken = "";
                while (nextPageToken != null)
                {
                    var playlistItemsListRequest = youtubeService.PlaylistItems.List("snippet");
                    playlistItemsListRequest.PlaylistId = uploadsListId;
                    playlistItemsListRequest.MaxResults = 20;
                    playlistItemsListRequest.PageToken = nextPageToken;

                    // list of videos uploaded
                    var playlistItemsListResponse = await playlistItemsListRequest.ExecuteAsync();

                    foreach (var playlistItem in playlistItemsListResponse.Items)
                    {
                        // Print information about each video.
                        Console.WriteLine("{0} ({1})", playlistItem.Snippet.Title, playlistItem.Snippet.ResourceId.VideoId);
                    }

                    nextPageToken = playlistItemsListResponse.NextPageToken;
                }
            }
        }
    }
}