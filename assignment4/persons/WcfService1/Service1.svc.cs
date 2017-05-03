using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace WcfService1
{
  
    public class Service1 : IService1
    {
        /// <summary>
        /// opens the xml file created in the first part of the assignment and the appends another person to it based on user input
        /// !!! important location of the xml file will be different on another computer please change the file path as necessary 
        /// it is essential for the add person and display results hyperlink to work!!!!
        /// </summary>
        /// <param name="firstName">persons first name</param>
        /// <param name="lastName">persons last name</param>
        /// <param name="newId"> persons id</param>
        /// <param name="newPassword">persons password</param>
        /// <param name="workPhone">persons work phone</param>
        /// <param name="cellPhone">persons cell phone</param>
        /// <param name="carrier">phone carrier</param>
        /// <param name="cat">how the person knows them ie work friend family</param>
        public void addPerson(  string firstName, string lastName, string newId, string newPassword, string workPhone, string cellPhone, string carrier, string cat)
        {
            //create a new xml document object to load the xml file
            XmlDocument doc1 = new XmlDocument();
            //my xml document is stored here, im sure yours will be different change the file path accordingly
            doc1.Load(@"C:\Users\matthew dunning\Documents\Visual Studio 2015\Projects\persons\WcfService1\xmlFile\persons.xml");
           

            //create the person node with its sub elements
            XmlElement person = doc1.CreateElement("person");
            XmlElement name = doc1.CreateElement("name");
            XmlElement first = doc1.CreateElement("first-name");
            XmlElement last = doc1.CreateElement("last-name");

            //create the credential node with its subelements and single attribute
            XmlElement cred = doc1.CreateElement("credential");
            XmlElement id = doc1.CreateElement("id");
            XmlElement password = doc1.CreateElement("password");
            XmlAttribute encrypted = doc1.CreateAttribute("encryption");
            encrypted.Value = "yes";

            //create the phone node with its subelements and its single attribute
            XmlElement phone = doc1.CreateElement("phone");
            XmlElement work = doc1.CreateElement("work");
            XmlElement cell = doc1.CreateElement("cell");
            XmlAttribute provider = doc1.CreateAttribute("provider");
            provider.Value = "optional";

            //create the category node
            XmlElement category = doc1.CreateElement("category");

            //add the name node as a child to person and set the elements of the name to the parameters that were passed
            person.AppendChild(name);
            name.AppendChild(first);
            name.AppendChild(last);
            first.InnerText = firstName;
            last.InnerText = lastName;

            //add the credentials as node to person and set the values passed from parameter to the password and id
            person.AppendChild(cred);
            cred.AppendChild(id);
            cred.AppendChild(password);
            password.SetAttribute("encryption", "yes");
            id.InnerText = newId;
            password.InnerText = newPassword;

            //add the phone node as a child of person and set up the corresponding variables
            person.AppendChild(phone);
            phone.AppendChild(work);
            phone.AppendChild(cell);
            cell.SetAttribute("provider", carrier);
            work.InnerText = workPhone;
            cell.InnerText = cellPhone;

            //add the category to person node as a child and set the value
            person.AppendChild(category);
            category.InnerText = cat;

            //append the entire person node to the xml file and save it again my path will be different than yours so change it accordingly
            doc1.DocumentElement.AppendChild(person);
            doc1.Save(@"C:\Users\matthew dunning\Documents\Visual Studio 2015\Projects\persons\WcfService1\xmlFile\persons.xml");
            
            
        }

        /// <summary>
        /// given an url path this searches the xml file for a persons name if it is found it returns all their information
        /// </summary>
        /// <param name="xmlFile">file to be read</param>
        /// <param name="name">persons first and last name</param>
        /// <returns></returns>
        public string search(string xmlFile, string name)
        {

            //create a new xml doc and read it in 
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFile);

            //generate default return value if name not found
            string info = "no such person";

            //split the string passed into a first and last name
            string first = name.Substring(0, name.IndexOf(" "));
            string last = name.Substring(name.IndexOf(" ") + 1);

            //get to the child of the root node to traverse
            XmlNodeList xnList = doc.SelectNodes("persons/person");

            //go through all the person nodes to locate name
            foreach (XmlNode xn in xnList)
            {
                //get the name from the nodes in xml doc
                string firstName = xn["name"]["first-name"].InnerText;
                string lastName = xn["name"]["last-name"].InnerText;

                //check if the names meet the name that was passed
                if (firstName == first && lastName == last)
                {
                    //if they do extract all the information pertaining to that person and store it in the return string
                    string id = xn["credential"]["id"].InnerText;
                    string password = xn["credential"]["password"].InnerText;
                    string encrytped = xn["credential"]["password"].Attributes["encryption"].Value;
                    string workPhone = xn["phone"]["work"].InnerText;
                    string cellPhone = xn["phone"]["cell"].InnerText;
                    string provider = xn["phone"]["cell"].Attributes["provider"].Value;
                    string category = xn["category"].InnerText;

                    info = "first and last name are :" +  "\"" + firstName + " " + lastName + "\"" + "\n the id is " + "\"" + id + "\"" + " and password is " + "\"" + password + "\"" + " \n will encryption be required " + "\"" + encrytped + "\"" +  " \n work phone is " + "\"" + workPhone + "\"" + " \n cell phone is " + "\"" + cellPhone + "\"" + " the provider if disclosed by the user is " + "\"" + provider + "\"" + " \n the category is " + "\"" + category + "\"";
                }
            }

            return info;
          

        }

       
    }
}
