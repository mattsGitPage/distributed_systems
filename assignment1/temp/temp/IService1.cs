using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace temp
{
   //interface
    [ServiceContract]
    public interface IService1
    {
        //defines the celcius to farenhiet function
        [OperationContract]
       int c2f(int c);
 
        //defines the farenhiet to celcius function
        [OperationContract]
        int f2c(int f);

    }
}
