using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eCommerce
{
    /// <summary>
    /// main driver for the ecommerce program
    /// contents derived from lecture slides
    /// </summary>
    class Program
    {
        //const num of retailers given in the assignment
        public const int numRetailer = 5;

        static void Main(string[] args)
        {
            //new chicken farm object
            ChickenFarm chicken = new ChickenFarm();

            //the farmer thread 
            Thread farmer = new Thread(new ThreadStart(chicken.farmerFunc));
            Thread order = new Thread(new ThreadStart(chicken.receiveOrder));
            order.Start();
            farmer.Start();

            Retailer chickenstore = new Retailer();
            ChickenFarm.priceCut += new priceCutEvent(chickenstore.chickensToOrder);
            ChickenFarm.confrim += new ConfrimationEvent(chickenstore.Confirmation);

            //declare and start the retailer threads
            Thread[] retailers = new Thread[numRetailer];

            for (int i = 0; i < numRetailer; i++)
            {   // Start N retailer threads

                retailers[i] = new Thread(new ThreadStart(chickenstore.retailerFunc));
                retailers[i].Name = (i + 1).ToString();
                retailers[i].Start();

            }

        }
    }
}
