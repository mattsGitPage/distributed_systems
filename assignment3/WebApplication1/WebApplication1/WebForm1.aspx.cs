using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    /// <summary>
    /// this is a youtube api it takes in a video id 
    /// then it searches the video and dispays the title and a description about it
    /// </summary>
    public partial class WebForm1 : System.Web.UI.Page
    {
        /// <summary>
        /// default page load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// listens for the search of a video
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            //create object to enccrypt the users video id
            crypt.ServiceClient encrypt = new crypt.ServiceClient();

            //get the video id and search it
            string id = TextBox1.Text;

            //encrypt the video id
            string eCrypt = encrypt.Encrypt(id);
            
            //decrypt the id 
            YouTubeVideo video = new YouTubeVideo(encrypt.Decrypt(eCrypt));
            
            //set the video titles and descripts
            Label4.Text = video.title;
            Label6.Text = video.description;
            
        }
    }
}