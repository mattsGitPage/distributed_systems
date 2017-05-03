using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tempASP
{
    //in order for this web page to run the temp service needs to be running in the browser
    //the local host is static 
    public partial class _Default : Page
    {
       
        protected void Button1_Click(object sender, EventArgs e)
        {
            //one variable for conversion
            int celcius;

            // create a new object to convert
            ServiceReference1.Service1Client temp = new ServiceReference1.Service1Client();

            // if first text box is not empty and conversion button is pushed
            if (TextBox1.Text.Trim() != "")
            {
                // get the information from the first text box
                celcius = Convert.ToInt32(TextBox1.Text);

                //assign the converted value to the next text box
                // text box will only handle string
                TextBox2.Text = temp.c2f(celcius).ToString();

            }
            else
            {
                //nothing entered so do nothing
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //one variable for conversions
            int farenheit;

            // create a new object to convert
            ServiceReference1.Service1Client temp = new ServiceReference1.Service1Client();

            // if first text box is not empty and conversion button is pushed
            if (TextBox3.Text.Trim() != "")
            {
                // get the information from the first text box
                farenheit = int.Parse(TextBox3.Text);

                //assign the converted value to the next text box
                // text box will only handle string
                TextBox4.Text = temp.f2c(farenheit).ToString();

            }
            else
            {
                //nothing entered so do nothing
            }
        }
    }
}