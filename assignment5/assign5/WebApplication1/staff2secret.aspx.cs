using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class staff2secret : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //sends the staff to view all staff1 and their passwords
            Response.Redirect("http://localhost:49861/xml/staffpage1users.xml");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //sends the staff to view all users and their passwords
            Response.Redirect("http://localhost:49861/xml/users.xml");
        }
    }
}