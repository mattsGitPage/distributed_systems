using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebApplication1
{
    public partial class staffPage1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"c:\Users\matthew dunning\documents\visual studio 2015\Projects\assign5\WebApplication1\xml\staffpage1users.xml"));

           

            //split the string passed into a first and last name
            string user = TextBox1.Text;
            string password = TextBox2.Text;
            string authenticate = TextBox3.Text;
            string authorize = TextBox4.Text;

            //get to the child of the root node to traverse
            XmlNodeList xnList = doc.SelectNodes("persons/person");

            bool found = false;
            //go through all the person nodes to locate name
            foreach (XmlNode xn in xnList)
            {
                //get the name from the nodes in xml doc
                string userName = xn["name"]["user-name"].InnerText;
                string userPassword = xn["credential"]["password"].InnerText;
                string auth = xn["authentication"]["id"].InnerText;
                string author = xn["authorization"]["status"].InnerText;

                //use to redirect to another page if login credentials are verified
                Response.BufferOutput = true;
                //check if the names meet the name that was passed
                if (user == userName && password == userPassword && auth == authenticate && author == authorize)
                {
                    //if they do extract all the information pertaining to that person and store it in the return string
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "successfully logged in" + "');", true);

                    //redirect them to the staff 1 page
                    Response.Redirect("http://localhost:49861/staff1secret");
                    found = true;
                }
            }

            if (!found)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "error invalid login" + "');", true);
            }

        }
    }
}