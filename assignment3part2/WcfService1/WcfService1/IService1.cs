﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{

    [ServiceContract]
    public interface IService1
    {

        
        [WebGet(UriTemplate = "/get?videoId")]
        string getSimilar();
       
        string GetRandomLetter(Random rnd, string[] consonants);

    }


  
}
