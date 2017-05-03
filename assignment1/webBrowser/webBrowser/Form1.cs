using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webBrowser
{
    public partial class Form1 : Form
    {
        //the asu web service needs to be running in order for the encrypt and decrypt functions to work
        //everything else is on the form and is independent of any hosts services
        public Form1()
        {
            InitializeComponent();
            loadcaptachaimage();
      
        }

        //global captcha variable
        String captcha = "";
        //function creates the captcha image
        private void loadcaptachaimage()
        {
            //create a string for all possibilities of the captacha image
            String str = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,1,2,3,4,5,6,7,8,9,0,!,@,#,$,%,^,&,*,(,),_,=,+,-,?,/,.,>,<";
            String[] array = str.Split(',');

            //generate two new random variables one for the length of the captcha and the other to choose the variables inside of it
            Random r = new Random();
            Random len = new Random();

            //make sure captcha is reset every time this function is called
            captcha = "";

            //generate the catpcha image of random length and variables 
            int temp = len.Next(3,7);
            for(int i = 0; i < temp; i++)
            {
                int num1 = r.Next(0, array.Length);
                captcha += array[num1];
            }
            
            // this sets the image of the captcha and also assigns text box  length of the string following
            var image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);
            var font = new Font("TimesNewRoman", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(captcha, font, Brushes.Black, new Point(0, 0));
            pictureBox1.Image = image;
            textBox2.Text = temp.ToString();

         }

        //function to go back in the web browser
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //this will navigate to the previous page
            webBrowser1.GoBack();
        }

        //function to navigate to url in web browser
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //what ever is entered here it will navigate
            webBrowser1.Navigate(toolStripTextBox1.Text);
        }
        
        //function to go forward in the web browser
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //this will navigate to the forward page
            webBrowser1.GoForward();
        }

        //function to refresh the web browser
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //this will refresh the browser
            webBrowser1.Refresh();
        }

        //function to refresh the captcha image
        private void button1_Click(object sender, EventArgs e)
        {
            //refresh the captcha image
            loadcaptachaimage();
        }

        //function to check if the proper input was inserted for the captcha image
        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == captcha)
            {
                MessageBox.Show("correctly matched the text");
            }
            else
            {
                MessageBox.Show("does not match");
                
                //after first failed attempt reload the captcha
                loadcaptachaimage();
            }
           
        }

        // random sequence of ascii character values for generating keys
      /*  private static byte[] replace = Encoding.ASCII.GetBytes("adfdfee23532");*/

        //encryption algorythm 
        //credits to RijindaelManafed class documentation and the MCTS training kit
        private void button3_Click(object sender, EventArgs e)
        {

            // the way asked to do it in the assignemnt
            // create a new instance of the encryption class and invoke the method
            ServiceReference1.ServiceClient i = new ServiceReference1.ServiceClient();
            textBox4.Text =  i.Encrypt(textBox3.Text);

            //this method is more secure and does not use duplicate IV keys which can be guessed
            // or possibly snooped over the air commented out for the assignment all it takes to work though
            //is to add a password box for encrytpion
            //variables for encrytion of string
           
          /*  RijndaelManaged alg;
            String encrypt = "";
           
                //create a new instance of psuedo random code generator 
                //then create the key for encryption based off of inputs
                //into the text box
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(textBox6.Text, replace);
                
                //create and return a key to use for encryption
                alg = new RijndaelManaged();
                alg.Key = key.GetBytes(alg.KeySize / 8);

                //perform the code transformation
                ICryptoTransform encryptor = alg.CreateEncryptor(alg.Key, alg.IV);

                using (MemoryStream crypt = new MemoryStream())
                {
                   //set up the IV key
                    crypt.Write(BitConverter.GetBytes(alg.IV.Length), 0, sizeof(int));
                    crypt.Write(alg.IV, 0, alg.IV.Length);

                    using (CryptoStream cS = new CryptoStream(crypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter sW = new StreamWriter(cS))
                        {
                            //Write to output stream.
                            sW.Write(textBox3.Text);
                        }
                    }

                    // assign the new encrypted values 
                    encrypt = Convert.ToBase64String(crypt.ToArray());

                    //display in the output textbox
                    textBox4.Text = encrypt;
                }*/
            
          
        }

        //instatiates an array for the encrytped text
      /*  private static byte[] ReadByteArray(Stream s)
        {
            byte[] rawLength = new byte[sizeof(int)];

            if (s.Read(rawLength, 0, rawLength.Length) != rawLength.Length)
            {
                throw new SystemException("formatting error");
            }

            byte[] buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
            if (s.Read(buffer, 0, buffer.Length) != buffer.Length)
            {
                throw new SystemException("read error");
            }

            return buffer;
        }*/

        //function to decrypt the text
        //credits to RijindaelManages class documentation and MCTS training kit
        private void button4_Click(object sender, EventArgs e)
        {
            //assignments way of decryption
            ServiceReference1.ServiceClient i = new ServiceReference1.ServiceClient();
            textBox5.Text  = i.Decrypt(textBox4.Text);

            //again a more secure way for encryption commented it out for the assignment 
            //just needs the password from encryption and it works the same
            // access to the rij algorithm and string for decryption
          /*  RijndaelManaged alg;
            String decrypt = "";

                //make the key from user entered password
                Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(textBox6.Text, replace);

                // Create the streams used for decryption.                
                byte[] map = Convert.FromBase64String(textBox4.Text);

                using (MemoryStream crypt = new MemoryStream(map))
                {
                   
                    //generate the appropriate keys for decryption
                    alg = new RijndaelManaged();
                    alg.Key = key.GetBytes(alg.KeySize / 8);
                    alg.IV = ReadByteArray(crypt);

                    // transform the encrypted stream
                    ICryptoTransform decryptor = alg.CreateDecryptor(alg.Key, alg.IV);

                    using (CryptoStream cS = new CryptoStream(crypt, decryptor, CryptoStreamMode.Read))
                    {
                         using (StreamReader sR = new StreamReader(cS))
                         {
                             //get the decrypted message and write it to the text box
                             decrypt = sR.ReadToEnd();
                             textBox5.Text = decrypt;
                         }  
                    }
                }*/

        }

        //fucntion to reset the text box fields
        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }


    }
}
