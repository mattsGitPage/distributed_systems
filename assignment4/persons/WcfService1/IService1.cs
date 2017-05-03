using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    
    /// <summary>
    /// service contract the defines what methods will be used in the service 
    /// </summary>
    [ServiceContract]
    public interface IService1
    {


        [OperationContract]
      string search(string xmlFile, string name);

        [OperationContract]
        void addPerson( string firstName, string lastName, string newId, string newPassword, string workPhone, string cellPhone, string carrier, string cat);

    }
}
