using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
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