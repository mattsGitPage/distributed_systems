using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    //This program uses RESTful service to implement the function
    //i edited the web.config file to remove the accees point as opposed
    //to using other methods

    //make this service run in asp.net compatibility mode 
    [AspNetCompatibilityRequirements
     (RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]

    public class Service1 : IService1
    {
        public string GetRandomLetter(Random rnd, string[] consonants)
        {
        return consonants[rnd.Next(0, consonants.Length - 1)];
        }

        public string getSimilar()
        {
            Random rnd = new Random();
            Random len = new Random();

            //create the appropriate strings to create video titles
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
            string[] vowels = { "a", "e", "i", "o", "u" };

            //variable to store the video title
            string videoTitle = "";
            int titleLength = len.Next(10,11);

                //create the random title so we can search it later
                for (int i = 0; i < titleLength; i += 2)
                {
                    videoTitle += GetRandomLetter(rnd, consonants) + GetRandomLetter(rnd, vowels);
                }
                
            

            return videoTitle;
        }
    }
}
