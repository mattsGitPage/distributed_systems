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
    /// this application will allow you to create a playlist on your youtube account
    /// please do not create any playlists on my account 
    /// this is based on the youtube api documentation
    /// </summary>
    internal class PlaylistUpdates
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("creating a playlist");
            Console.WriteLine();
            Console.WriteLine();

            //begin executing the playlist creation code
            try
            {
                new PlaylistUpdates().Run().Wait();
            }

            //catch any errors
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }

            Console.WriteLine("playlist created press enter to terminate the program");
            Console.ReadKey();
        }

        private async Task Run()
        {
            UserCredential credential;

            //opens the json file that contains the oauth id and the api information to validate access to the account
            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { YouTubeService.Scope.Youtube },
                    "user",
                    CancellationToken.None,
                    new FileDataStore(this.GetType().ToString())
                );
            }

            //intialize the service that will be the interfacing mechanism
            //set up authentication as well
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = this.GetType().ToString()
            });

            // this creates the playlist by setting up all the details of the playlist
            //TODO check youtube api documentation to implement more features
            var newPlaylist = new Playlist();
            newPlaylist.Snippet = new PlaylistSnippet();
            newPlaylist.Snippet.Title = "assignment 3 api created playlist";
            newPlaylist.Snippet.Description = "A playlist for 445 using an api";

            //determines who can view it and then create the playlist videos can be added later
            newPlaylist.Status = new PlaylistStatus();
            newPlaylist.Status.PrivacyStatus = "public";
            newPlaylist = await youtubeService.Playlists.Insert(newPlaylist, "snippet,status").ExecuteAsync();

            // Add a video to the playlist
            //in order to change back and forth between different playlists a new section needs to be developed
            // for this assignment i will just create a single playlist without manuverability
            var newPlaylistItem = new PlaylistItem();
            newPlaylistItem.Snippet = new PlaylistItemSnippet();
            newPlaylistItem.Snippet.PlaylistId = newPlaylist.Id;
            newPlaylistItem.Snippet.ResourceId = new ResourceId();
            newPlaylistItem.Snippet.ResourceId.Kind = "youtube#video";

            //this can be linked to the video search in the web application
            newPlaylistItem.Snippet.ResourceId.VideoId = "GNRMeaz6QRI";
            newPlaylistItem = await youtubeService.PlaylistItems.Insert(newPlaylistItem, "snippet").ExecuteAsync();

            Console.WriteLine("video id {0} was added to playlist ", newPlaylistItem.Id);
        }
    }
}