using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    /// <summary>
    /// class contains both the methods to encode an order and also decode it
    /// </summary>
    public class EncodeDecode
    {

        /// <summary>
        /// takes an order and converts it to a string as per the assignment
        /// </summary>
        /// <param name="order"> the order that will be converted to a string</param>
        /// <returns>the order as a string object</returns>
        public string Encoder(Order order)
        {

            string encodedString =
                Convert.ToString(order.getID()) + ","
              + Convert.ToString(order.getCardNo()) + ","
              + Convert.ToString(order.chickensToBePurchased()) + ","
              + Convert.ToString(order.singleChickenCost()) + ","
              + Convert.ToString(order.getConfirmation()) + ","
              + Convert.ToString(order.getTimeStamp());
            return encodedString;

        }

        /// <summary>
        /// decodes the string order into an order object
        /// </summary>
        /// <param name="encodedString"></param>
        /// <returns></returns>
        public Order Decoder(string encodedString)
        {
            Order order = new Order();

            string[] tokenizer = encodedString.Split(',');
            order.setID(Convert.ToInt32(tokenizer[0]));
            order.setCardNo(Convert.ToInt32(tokenizer[1]));
            order.setChickensToBePurchased(Convert.ToInt32(tokenizer[2]));
            order.setSingleChickenCost(Convert.ToInt32(tokenizer[3]));
            order.setConfirmation(Convert.ToBoolean(tokenizer[4]));
            order.setTimeStamp(Convert.ToDateTime(tokenizer[5]));

            return order;
        }
    }
}
