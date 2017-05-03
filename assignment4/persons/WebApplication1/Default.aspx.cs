using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {

        /// <summary>
        /// default page load sets the hyperlink so the user can view the xml file as per the assignment 
        /// </summary>
        /// <param name="sender">listeners</param>
        /// <param name="e">listeners</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink1.NavigateUrl = "http://localhost:27101/xmlFile/persons.xml";
            HyperLink1.Text = "click here to view xml";
        }

        /// <summary>
        /// create a new person in the xml file with the attributes specified by the user
        /// </summary>
        /// <param name="sender">listeners</param>
        /// <param name="e">listeners</param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client addNode = new ServiceReference1.Service1Client();

            string first = TextBox1.Text;
            string last = TextBox2.Text;
            string id = TextBox3.Text;
            string password = TextBox4.Text;
            string workP = TextBox5.Text;
            string cellP = TextBox6.Text;
            string provider = TextBox7.Text;
            string cat = TextBox8.Text;
           
            //call the service to create the new person node in the xml file
            addNode.addPerson(first, last, id, password, workP, cellP, provider, cat);

            Label14.Text = "new node has been created ";

        }

        /// <summary>
        /// searches for a person based on the xml file path and the first and last name of that person
        /// </summary>
        /// <param name="sender">listeners</param>
        /// <param name="e">listeners</param>
        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client search = new ServiceReference1.Service1Client();

            string name = TextBox9.Text;
            string url = TextBox10.Text;
            string result = "please enter a valid xml file location";

            if (url == "http://localhost:27101/xmlFile/persons.xml")
            {
                result = search.search(url, name);
            }
            Label13.Text = result;
        }

       
    }
}