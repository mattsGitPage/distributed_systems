using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eCommerce
{
    //delgates for the order confirmation and the price cut event
    public delegate void priceCutEvent(int price);
    public delegate void ConfrimationEvent(Order order);

    /// <summary>
    /// started as a thread by main
    /// uses a pricing model to determine chicken prices
    /// defines a price cutevent and call the event handlers in retailers if there is a price cut
    /// recieves the orders encoded from the buffer
    /// calls the decoder to convert the string to order object
    /// for each order it starts a new thread
    /// there is a counter and after it hits eg 10 price cuts the thread will terminate
    /// </summary>

    public class ChickenFarm
    {
        //counter to detrmine program termination
        public static int cut = 0;
        static Random rng = new Random();

        //delegate variables
        public static event priceCutEvent priceCut;
        public static event ConfrimationEvent confrim;

        public static int costOfSingleChicken = 7;
        public int getChickenCost() { return costOfSingleChicken; }

        /// <summary>
        /// function that changes the going price of a chicken
        /// credit to the lecture slides
        /// </summary>
        public static void changePrice(int price)
        {
            for (int i = 0; i < 50; i++)
            {

                if (price < costOfSingleChicken)
                { // a price cut 

                    priceCut?.Invoke(price);    // emit event to subscribers
                    cut++;
                }
                if (cut == 10)
                {
                    Console.WriteLine("10 price cuts the chicken farm is shutting down");
                    Console.WriteLine("press enter to shut the console down and terminate all threads");
                    Console.ReadLine();
                    Environment.Exit(Environment.ExitCode);

                }
                costOfSingleChicken = price;
            }
        }

        /// <summary>
        /// random price generator 
        /// credit to the lecture slides
        /// </summary>
        public void farmerFunc()
        {
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(500);
                // Take the order from the queue of the orders;
                // Decide the price based on the orders
                Int32 p = rng.Next(5, 10); // Generate a random price
                // Console.WriteLine("New Price is {0}", p);
                ChickenFarm.changePrice(p);
            }
        }

        /// <summary>
        /// this function recieves orders in encoded form
        /// from the multi cell buffer
        /// </summary>
        public void receiveOrder()
        {
            //object to access the multicell buffer
            buff cells = new buff();
            //string to hold the order string from the buffer
            string orderString = null;

            for (int i = 0; i < 40; i++)
            {
                Thread.Sleep(50);

                //get the string from the multi cell buffer
                orderString = cells.getOneCell();


                //make sure the string isnt an empty order
                if (orderString != null)
                {
                    //create new thread for each order
                    Console.WriteLine("order recieved from the buffer");
                    Thread OrderProcessingThread = new Thread(new ParameterizedThreadStart(OrderProcessing));
                    OrderProcessing(orderString);
                }
            }
        }

        /// <summary>
        /// process the order based on the current price
        /// calculate the total price based on tax total shipping
        /// send confirmation to retailer when completed
        /// use a call back function
        /// </summary>
        /// <param name="orderToProcess"> the order process</param>
        private void OrderProcessing(object orderToProcess)
        {
            string orderString = orderToProcess.ToString();

            // declare a new decoder object to decode the order string from the buffer
            EncodeDecode decode = new EncodeDecode();
            Order order = decode.Decoder(orderString);


            Console.WriteLine("an order was processed from Store # : {0}", order.getID());

            //get the credit card information from the order
            int creditCard = order.getCardNo();

            //the total before shipping and hanlding
            float subtotal = (order.singleChickenCost() * order.chickensToBePurchased());
            //the total after tax and shipping have been added
            float total = order.getShipping() + (order.getTax() * subtotal);

            Console.WriteLine("Store # {0} purchased {1} chickens for the total price of {2}", order.getID(), order.chickensToBePurchased(), total);

            //check if the credit card is valid
            if (creditCard >= 6000 && creditCard <= 7000)
            {
                order.setConfirmation(false);

                //send confirmation to the retailer
                confrim(order);
            }
            else
            {
                Console.WriteLine("an invalid credit card was submitted by the client with ID : {0}", order.getID());
            }
        }
    }//end of chicken farm
}
