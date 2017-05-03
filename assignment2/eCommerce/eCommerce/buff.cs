using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eCommerce
{
    /// <summary>
    /// class used for sending the order from the retailers to the chickenfarm
    /// class has n =2 data cells and N =5 number of retailers
    /// using monitor lock and semaphore
    /// </summary>
    public class buff
    {
        //n =2 as per the assignment
        public const int dataCell = 2;

        /// <summary>
        /// class that is used in an array to hold order contents
        /// </summary>
        public class cell
        {
            public string order = null;
        }

        //use a semaphore of value n to manage cells as per assignment
        public static Semaphore semaphore = new Semaphore(0, dataCell);

        //create a new array of cells for the buffer
        public static cell[] buffers = new cell[dataCell];

        /// <summary>
        /// reads one cell or order from the multibuffer and then
        /// clears it and makes it available to be written to again
        /// </summary>
        /// <returns> the order that was store in the cell</returns>
        public string getOneCell()
        {
            string cellContent = "";

            semaphore.WaitOne();
            for (int i = 0; i < dataCell; i++)
            {
                Thread.Sleep(100);
                //lock the buffer to read
                Monitor.Enter(buffers[i]);
                try
                {
                    cellContent = buffers[i].order;
                    buffers[i].order = "";
                }
                finally
                {
                    //unlock the buffer for later use and increment the semaphore count
                    Monitor.Exit(buffers[i]);
                    semaphore.Release();
                }

                //make sure there is no null contents and return the cell contents
                if (cellContent != null)
                    return cellContent;
            }
            return null;
        }

        /// <summary>
        /// this writes the contents of an order to the multicell buffer
        /// </summary>
        /// <param name="order">the contents to be written to the buffer</param>
        public void setOneCell(object order)
        {
            string writeTo = order.ToString();

            //block the thread
            semaphore.WaitOne();

            for (int i = 0; i < dataCell; i++)
            {
                Thread.Sleep(100);
                //lock the buffer
                Monitor.Enter(buffers[i]);
                try
                {
                    buffers[i].order = writeTo;
                }
                finally
                {
                    //unlock the buffer and increment the semaphore count
                    Monitor.Exit(buffers[i]);
                    semaphore.Release();
                }
            }
        }
    }
}
