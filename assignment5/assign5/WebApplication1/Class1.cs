using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Class1
    {
        public static string encryptIt(string code)
        {
            
            ServiceReference2.ServiceClient i = new ServiceReference2.ServiceClient();

            string result = i.Encrypt(code);
            return result;
        }

        public static string decryptIt(string code)
        {
           
            ServiceReference2.ServiceClient i = new ServiceReference2.ServiceClient();
            string result = i.Decrypt(code);
            return result;
        }

        public static string currentUser { get; set; }


    }
}