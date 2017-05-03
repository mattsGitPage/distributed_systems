using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class FragmentCtrl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CacheEntryTime.Text = "FragmentCtrl1: " + DateTime.Now.TimeOfDay.ToString();
        }
    }
}