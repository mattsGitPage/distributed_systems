using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client addNode = new ServiceReference1.Service1Client();

            string first = TextBox1.Text;
            string last = TextBox2.Text;
            string id = TextBox3.Text;
            string password = TextBox4.Text;
            string workP = TextBox8.Text;
            string cellP = TextBox5.Text;
            string provider = TextBox6.Text;
            string cat = TextBox7.Text;

           // addNode.addPerson(first, last, id, password, workP, cellP, provider, cat);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client search = new ServiceReference1.Service1Client();

            string name = TextBox9.Text;
            string url = TextBox10.Text;

            string result = search.search(url, name);

            Label13.Text = result;
        }
    }
}