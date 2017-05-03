using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    /// <summary>
    /// all the hyperlinks and info given in the public page
    /// </summary>
    public partial class _public : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HyperLink1.NavigateUrl = "http://localhost:49861/members";
            HyperLink2.NavigateUrl = "http://localhost:49861/staffPage1";
            HyperLink3.NavigateUrl = "http://localhost:49861/staffPage2";
            HyperLink4.NavigateUrl = "http://localhost:49861/membersSecret";
            HyperLink5.NavigateUrl = "http://venus.eas.asu.edu/WSRepository/Services/EncryptionTryIt/Sender.aspx";
            HyperLink6.NavigateUrl = "http://localhost:49861/members";
            HyperLink7.NavigateUrl = "http://localhost:49861/members";
            HyperLink8.NavigateUrl = "http://localhost:49861/membersSecret";
            HyperLink9.NavigateUrl = "http://localhost:49861/WebService1.asmx";
            HyperLink10.NavigateUrl = "http://localhost:49861/WebService1.asmx?op=createHashCode";
            HyperLink11.NavigateUrl = "http://localhost:49861/members";
            HyperLink12.NavigateUrl = "http://localhost:49861/ageVerify.asmx";
            HyperLink13.NavigateUrl = "http://localhost:49861/ageVerify.asmx";
        }
    }
}