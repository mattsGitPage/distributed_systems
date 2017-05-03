using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for ageVerify and hash code generation
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ageVerify : System.Web.Services.WebService
    {

        [System.Web.Services.WebMethod()]
        public string validateAge(int age)
        {
            string result = "not old enough to enter the page";
            if(age >= 18)
            {
                result = "enter the page";
            }
            return result;
        }

        [System.Web.Services.WebMethod()]
        public string createHashCode(string code, string salt)
        {
            ServiceReference3.ServiceClient hash = new ServiceReference3.ServiceClient();
            return  hash.Hash(code, salt);
        }
    }
}
