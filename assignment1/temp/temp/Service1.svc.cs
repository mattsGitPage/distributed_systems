using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace temp
{
    //run this is web browser the local host is set as static http://localhost:11991/Service1.svc
    // in order for the web form to work this service needs to be active in web browser

    public class Service1 : IService1
    {
        //function that converts celcius into farenhiet
        public int c2f(int c)
        {
            int farenheit =(int)( c * 1.8 ) +32;
            return farenheit;
        }

        //function that converts farenheit to celcius
        public int f2c(int f)
        {
            int c =(int) ((f - 32) * (5.0 / 9.0));
            return c;
        }
    }
}
