using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eCommerce
{
    /// <summary>
    /// assignment instructions include N = 5 for rtailer threads and n = 2 for data cell and semphore value
    /// the actions are derived from the delegate events
    /// each has a call back method for the chickenfarm call when a price cut happens
    /// each order is an order class object and the thread terminates when chicken farm thread terminates
    /// when confirmation is recieved the the time of the order will be printed to the screen
    /// </summary>
    public class Retailer
    {
        //variable to keep the time stamp of the sale
        public static DateTime timeStamp;
        //id of the purchaser
        public int id;

        /// <summary>
        /// retailer thread instantiated from the same class
        /// </summary>
        /// <returns>returns the ratailer 1 through N threads running</returns>

        public void retailerFunc()
        {
            id = Convert.ToInt32(Thread.CurrentThread.Name);
            ChickenFarm farm = new ChickenFarm();
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("Store {0} has everyday low price: ${1} each", Thread.CurrentThread.Name, farm.getChickenCost());
            }
        }

        /// <summary>
        /// method to generate credit card number
        /// </summary>
        /// <returns>the credit card number</returns>
        public int generateCreditCard()
        {
            Random creditCard = new Random();
            int CCnumber = creditCard.Next(1000, 7000);
            return CCnumber;
        }

        bool needOfChicken = true;
        /// <summary>
        /// as per assignment method to determind chicken demand
        /// Event handler
        /// </summary>
        /// <param name="price"></param>
        public void chickensToOrder(int price)
        {

            int quantity;
            //as per the assignment this determines what the need of the chicken is
            if (needOfChicken)
            {
                Random highNeed = new Random();
                quantity = highNeed.Next(25, 50);
                needOfChicken = false;
            }
            else
            {
                Random lowNeed = new Random();
                quantity = lowNeed.Next(10, 20);
                needOfChicken = true;
            }

            Console.WriteLine("Store {0} chickens are on sale: as low as ${1} each", id, price);

            //generate the cc number
            int card = generateCreditCard();

            ChickenFarm farm = new ChickenFarm();

            //set the order variables to prepare for sending 
            Order order = new Order();
            order.setID(id);
            order.setCardNo(card);
            order.setChickensToBePurchased(quantity);
            order.setSingleChickenCost(farm.getChickenCost());
            order.setTimeStamp(DateTime.Now);
            order.setConfirmation(false);

            //set the sale price of the individual chicken


            //the order was just placed so send and confirm the order 
            deliveryReport(order);
       

        }

        /// <summary>
        /// this fucntion encodes the order and sends it to be confirmed
        /// each order is also processed with a new thread
        /// </summary>
        /// <param name="order">the order that needs confirmation</param>
        public void deliveryReport(Order order)
        {
            //generate new object to encode the order to a string
            EncodeDecode encode = new EncodeDecode();

            //create a new buffer to write the order to the multibuffer
            buff cells = new buff();

            //call to start execution of the thread
            Thread orders = new Thread(new ParameterizedThreadStart(cells.setOneCell));

            //confirm the  ordre
            Confirmation(order);
            
            // create a new thread for each order as per the assignment
            orders.Start(encode.Encoder(order));

            

        }

        /// <summary>
        /// send confirmation to the retailer that the order has been confirmed
        /// use a call-back method as per the assignment
        /// </summary>
        /// <param name="order"> the order that was just placed</param>
        public void Confirmation(Order order)
        {
            //check if the order has been confirmed
            if (order.getConfirmation() == false)
            {
              
                //set the confirmation to true
                order.setConfirmation(true);
                Console.WriteLine(" {0} chickens were just confirmed sold to Store #: {1} the time of the order was: {2} ", order.chickensToBePurchased(), order.getID(), order.getTimeStamp());

            }
        }

    }
}
