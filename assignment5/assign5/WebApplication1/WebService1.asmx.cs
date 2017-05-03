using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string help()
        {
            return "help: once running the application just follow the link of the default page \n it will take you to the public page where you will be able to sign up or sign in as a member or a staff member \n once you have created an account you will have access to the youtube video id search function and explore all the videos on youtube";
        }

        [WebMethod]
        public string createHashCode(string code, string salt)
        {
            ServiceReference3.ServiceClient hash = new ServiceReference3.ServiceClient();
           return  "hash implemented " + hash.Hash(code, salt);
        }
    }
}
