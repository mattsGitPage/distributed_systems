using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Runtime.Serialization;
using System.Collections.Specialized;
using System.Text;


using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;


namespace WebApplication2
{
    public partial class _Default : Page
    {
        //global variables set in a class of their own
        //so when one is updated it stays updated
        //this is the requierment for any web application 
        //this is used to find similar videos that the user enterd
        public static class globals
        {
            public static string vidTitle = "";
        }
        //default page load
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        
    

        protected void Button1_Click1(object sender, EventArgs e)
        {

            string id = TextBox1.Text;

            //encrypt the video id


            //decrypt the id 
            YouTubeVideo video = new YouTubeVideo(id);

            //set the video titles and descripts
            Label3.Text = video.title;
            Label5.Text = video.description;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();

            string simVidId = TextBox2.Text;
            YouTubeVideo[] videos = youTubeApi.getList(simVidId);

            foreach(var video in videos)
            {
                ListBox1.Items.Add(video.title + " (" + video.id + ")");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
       
        }
    }
}