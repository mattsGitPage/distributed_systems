using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using WebApplication1;



namespace WebApplication1
{
    public partial class member : System.Web.UI.Page
    {

        public class names
        {
            public static string captcha = "";

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

    
        protected void Button1_Click(object sender, EventArgs e)
        {
            //use the webservice to validate that the user is of age
            webservice.ageVerifySoapClient s = new webservice.ageVerifySoapClient();
            string ofAge = s.validateAge(Convert.ToInt32(TextBox9.Text));

            if (ofAge == "not old enough to enter the page")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "you are not old enough to view the contents on this page" + "');", true);
            }
            else if(ofAge != "not old enough to enter the page")
            {

                //create a new xml document object to load the xml file
                XmlDocument doc1 = new XmlDocument();
                //my xml document is stored here, im sure yours will be different change the file path accordingly

                doc1.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"c:\Users\matthew dunning\documents\visual studio 2015\Projects\assign5\WebApplication1\xml\users.xml"));


                if (TextBox2.Text == TextBox3.Text && names.captcha == TextBox8.Text)
                {
                    //create the person node with its sub elements
                    XmlElement person = doc1.CreateElement("person");
                    XmlElement name = doc1.CreateElement("name");
                    XmlElement user = doc1.CreateElement("user-name");


                    //create the credential node with its subelements and single attribute
                    XmlElement cred = doc1.CreateElement("credential");
                    XmlElement password = doc1.CreateElement("password");
                    XmlAttribute encrypted = doc1.CreateAttribute("encryption");
                    encrypted.Value = "yes";

                    //add the name node as a child to person and set the elements of the name to the parameters that were passed
                    person.AppendChild(name);
                    name.AppendChild(user);
                    user.InnerText = TextBox6.Text;


                    //add the credentials as node to person and set the values passed from parameter to the password and id
                    person.AppendChild(cred);
                    cred.AppendChild(password);
                    password.SetAttribute("encryption", "yes");

                    password.InnerText = TextBox3.Text;


                    //append the entire person node to the xml file and save it again my path will be different than yours so change it accordingly
                    doc1.DocumentElement.AppendChild(person);
                    doc1.Save(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"c:\Users\matthew dunning\documents\visual studio 2015\Projects\assign5\WebApplication1\xml\users.xml"));

                    Label6.Text = "your account has been created!";
                }
            }
                else
                {
                    Label6.Text = " either your passwords do no match or the captcha image entered was incorrect";
                }



       
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient image = new ServiceReference1.ServiceClient();
            Random len = new Random();
            int length = len.Next(4, 8);
            TextBox7.Text = Convert.ToString(length);
            names.captcha = image.GetVerifierString(Convert.ToString(length));

            Image1.AlternateText = names.captcha;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"c:\Users\matthew dunning\documents\visual studio 2015\Projects\assign5\WebApplication1\xml\users.xml"));

            //get user enter name and password
            string user = TextBox4.Text;
            string password = TextBox5.Text;
           

            //get to the child of the root node to traverse
            XmlNodeList xnList = doc.SelectNodes("persons/person");

            bool found = false;
            //go through all the person nodes to locate name
            foreach (XmlNode xn in xnList)
            {
                //get the name from the nodes in xml doc
                string userName = xn["name"]["user-name"].InnerText;
                string userPassword = xn["credential"]["password"].InnerText;

                //use to redirect to another page if login credentials are verified
                Response.BufferOutput = true;
                //check if the names meet the name that was passed
                if (user == userName && password == userPassword)
                {

                    Class1.currentUser = user;
                    //if they do extract all the information pertaining to that person and store it in the return string
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "successfully logged in" + "');", true);
                    Response.Redirect("http://localhost:49861/membersSecret");
                    found = true;
                }
            }
            
            if(!found)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + "error invalid login" + "');", true);
            }


            

        }
    }
}