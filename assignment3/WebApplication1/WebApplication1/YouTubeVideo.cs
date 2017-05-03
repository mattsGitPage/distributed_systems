using System;

namespace WebApplication1
{
    /// <summary>
    /// video information
    /// </summary>
    public class YouTubeVideo
    {
        public string id, title, description;

        public YouTubeVideo(string id)
        {
            this.id = id;
            youTubeApi.GetVideoInfo(this);
        }
    }
}