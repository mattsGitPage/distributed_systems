using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace Google.Apis.YouTube.Samples
{
    /// <summary>
    /// this is based on the youtube api documentation
    /// !!!! IMPORTANT I DO NOT WANT YOU UPLOADING VIDEOS TO MY ACCOUNT SO IF YOU WANT TO ADD YOUR OWN API OR JUST VALIDATE THE CODE
    /// MECHANICS PLEASE DO SO. THE video file SHOULD BE UPLOADED THROGH THE DEBUG FOLDER!!
    /// !!!  THERE WILL ALWAYS BE AN ERROR SINCE NO VIDEO IS PLACED IN THE DEBUG FOLDER!!
    /// </summary>
    internal class UploadVideo
    {


         private async Task Run()
        {
            UserCredential credential;

            //this uses the oauth keys and the api keys to verify account access
            //if you want to upload please change the keys to your account specs
            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    // allow video upload to account
                    new[] { YouTubeService.Scope.YoutubeUpload },
                    "user",
                    CancellationToken.None
                );
            }

            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = Assembly.GetExecutingAssembly().GetName().Name
            });

            //this sets the video information
            //once generated you can link the id to the search
            var video = new Video();
            video.Snippet = new VideoSnippet();
            video.Snippet.Title = "Kali linux intro to reaver";
            video.Snippet.Description = "how exactly reaver works by targeting a wps key";
            video.Snippet.Tags = new string[] { "Kali", "reaver" };
            video.Snippet.CategoryId = "22"; 

            //this determines the viewability if other users are allowed to watch the video
            video.Status = new VideoStatus();
            video.Status.PrivacyStatus = "public";

            //specify the name of the video 
            //uploaded through the debug folder
            var filePath = @"ReaverUnleashed.mp4"; 

            //get the path to the video location to properly upload it
            using (var fileStream = new FileStream(filePath, FileMode.Open))
            {
                //start the uploading process and verify the upload
                var videosInsertRequest = youtubeService.Videos.Insert(video, "snippet,status", fileStream, "video/*");
                //create an event and subscribe to it for progress status of video upload
                videosInsertRequest.ProgressChanged += event1;
                videosInsertRequest.ResponseReceived += event2Success;

                await videosInsertRequest.UploadAsync();
            }
        }
        //event to verify upload
        void event1(Google.Apis.Upload.IUploadProgress progress)
        {
            //check if the video is being uploaded or if it failed
            switch (progress.Status)
            {
                case UploadStatus.Uploading:
                    Console.WriteLine("{0}  bytes transferd .", progress.BytesSent);
                    break;

                case UploadStatus.Failed:
                    Console.WriteLine("An error occurred check the debug log for more information error code: \n{0}", progress.Exception);
                    break;
            }
        }

        //another event to listen 
        void event2Success(Video video)
        {
            Console.WriteLine("the video has been successfully added to your account.");
        }
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("this application allows easy video upload access");
            Console.WriteLine();
            Console.WriteLine();

            //start up the process of uploading a video
            try
            {
                new UploadVideo().Run().Wait();
            }

            //catch and display any errors
            //the only error that will for sure happen is if no video is placed in the 
            //debug folder to upload
            //again please do not upload videos to my account
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }

            Console.WriteLine("Press enter to terminate the program");
            Console.ReadKey();
        }
    }
}