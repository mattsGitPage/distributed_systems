using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using WebApplication1;
using System.IO;


/// <summary>
/// 
/// after the user enters his correct login name he is redirected to this page and is able 
/// to use the application to look up youtube videos. this uses the DLL library for encryption and decryption
/// as per the assignment
/// </summary>

namespace WebApplication1
{
    public partial class membersSecret : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            //create object to enccrypt the users video id
            

            //get the video id and search it
            string id = TextBox1.Text;

            //use the DLL functions as per the assignment of encrypt and decrypt
           string encrypt =  Class1.encryptIt(id);
           string decrypt = Class1.decryptIt(encrypt);
         
           
           //get the video info
            YouTubeVideo video = new YouTubeVideo(decrypt);

            //set the video titles and descripts
            Label1.Text = video.title;
            Label2.Text = video.description;

        }
    }
}