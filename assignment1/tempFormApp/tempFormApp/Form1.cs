using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tempFormApp
{
    // in order for this web form to work the temp application needs to be running in the web browser
    // the local host is set to static 
    public partial class Form1 : Form
    {
        // function initializes the form component
        public Form1()
        {
            InitializeComponent();
        }

        // function that listens for the button and performs the temp conversion
        private void button1_Click(object sender, EventArgs e)
        {
            //one variable for conversion
            int celcius;

            // create a new object to convert
            ServiceReference1.Service1Client temp = new ServiceReference1.Service1Client();

            // if first text box is not empty and conversion button is pushed
            if (textBox2.Text.Trim() != "")
            {
                // get the information from the first text box
                celcius = Convert.ToInt32(textBox2.Text);

                //assign the converted value to the next text box
                // text box will only handle string
                textBox1.Text = temp.c2f(celcius).ToString();

            }
            else
            {
                MessageBox.Show("please enter a value to be converted");
            }

        }

        // function that listens for the button and performs the temp conversion
        private void button2_Click(object sender, EventArgs e)
        {
            //two variable for conversions
            int farenheit;

            // create a new object to convert
            ServiceReference1.Service1Client temp = new ServiceReference1.Service1Client();

            // if first text box is not empty and conversion button is pushed
            if (textBox3.Text.Trim() != "")
            {
                // get the information from the first text box
                farenheit = int.Parse(textBox3.Text);

                //assign the converted value to the next text box
                textBox4.Text = temp.f2c(farenheit).ToString();

            }
            else
            {
                MessageBox.Show("please enter a value to be converted");
            }
        }
    }
}
