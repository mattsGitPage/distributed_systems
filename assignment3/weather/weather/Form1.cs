using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Web.UI;


namespace weather
{
    /// <summary>
    /// API ID may not be available if you get an unautherized error please just enter your own api id a settings doc is provided with the key already set up for entry
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.webBrowser1.Navigate("about:blank");
        }
        private string GetWOEID(string zipCode)
        {
            string zip =String.Format("http://where.yahooapis.com/v1/places.q('{0}')?appid={1}", zipCode, YahooAPI_ID.Default.appId);
            XmlDocument data = new XmlDocument();
            data.Load(zip);
            XmlNodeList list = data.GetElementsByTagName("woeid");

            return list[0].InnerText;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 4)
            {
                if (IsNumber(textBox1.Text.Trim()))
                {
                    errorProvider1.SetError(textBox1, "");

                    label3.Text = GetWOEID(textBox1.Text.Trim());

                    this.webBrowser1.Navigate("about:blank");
                    this.webBrowser1.Refresh();

                    GetWeather();


                }
                else errorProvider1.SetError(textBox1, "must be numeric");

            }
            else
                errorProvider1.SetError(textBox1, "enter zip");
            

            
        }
        private bool IsNumber(string text)
        {
            Regex r = new Regex(@"^[-=]?[0-9]*\.?[0-9]+$");
            return r.IsMatch(text);
        }
        private void GetWeather()
        {
            string query = String.Format("http://weather.yahooapis.com/forecastrss?w={0}", label3.Text.Trim());
            XmlDocument data = new XmlDocument();
            data.Load(query);

            XmlNode channel = data.SelectSingleNode("rss").SelectSingleNode("channel");
            string title = channel.SelectSingleNode("title").InnerText;

            Console.WriteLine(title);

            string link = channel.SelectSingleNode("link").InnerText;
            Console.WriteLine(link);

            string description = channel.SelectSingleNode("description").InnerText;
            Console.WriteLine(description);

            string lastBuildDate = channel.SelectSingleNode("lastBuildDate").InnerText;
            Console.WriteLine(lastBuildDate);

            XmlNamespaceManager man = new XmlNamespaceManager(data.NameTable);
            man.AddNamespace("yweather", "http://xml.weather.yahoo.com/ns/rss/1.0");

            string city = channel.SelectSingleNode("yweather:location",man).Attributes["city"].Value;
            Console.WriteLine(city);

            string region = channel.SelectSingleNode("yweather:location", man).Attributes["region"].Value;
            Console.WriteLine(region);

            string country = channel.SelectSingleNode("yweather:location", man).Attributes["country"].Value;
            Console.WriteLine(country);

            string temperature = channel.SelectSingleNode("yweather:units", man).Attributes["temperature"].Value;
            Console.WriteLine(temperature);

            string chill = channel.SelectSingleNode("yweather:wind", man).Attributes["chill"].Value;
            Console.WriteLine(chill);

            string humidity = channel.SelectSingleNode("yweather:atmosphere", man).Attributes["humidity"].Value;
            Console.WriteLine(humidity);

            string sunrise = channel.SelectSingleNode("yweather:astronomy", man).Attributes["sunrise"].Value;
            Console.WriteLine(sunrise);

            string sunset = channel.SelectSingleNode("yweather:astronomy", man).Attributes["sunset"].Value;
            Console.WriteLine(sunset);

            string cdata = channel.SelectSingleNode("item", man).SelectSingleNode("description").InnerText;
            Console.WriteLine(cdata);

            StringWriter sw = new StringWriter();

            HtmlTextWriter hw = new HtmlTextWriter(sw);

            hw.RenderBeginTag(HtmlTextWriterTag.Html);
            hw.RenderBeginTag(HtmlTextWriterTag.Head);
            hw.RenderBeginTag(HtmlTextWriterTag.Body);

            hw.WriteLine(title + "<br />");
            hw.Write(cdata);
            hw.RenderEndTag();
            hw.RenderEndTag();
            hw.RenderEndTag();

            hw.Close();
            HtmlDocument doc = this.webBrowser1.Document;
            doc.Write(sw.ToString());



        }
    }
}
