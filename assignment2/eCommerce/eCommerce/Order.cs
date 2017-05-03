using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce
{
    /// <summary>
    /// class contain the senderId and the credit card number plis the amount of chickens order
    /// price was added to set the shipping and tax fees plus the timestamp  to generate when
    /// a purchase was placed as per the assignment
    /// it uses public methods to get and set the private data members
    /// </summary>
    public class Order
    {
        //private variables

        private bool confirmation = false;
        private const int shipping = 10;
        private const float tax = 0.1f;
        private int senderId;
        private int cardNo;
        private int amount;
        private int priceOfSingleChicken;
        private DateTime timeStamp;

        //empty constructor to give access to the methods
        public Order() { }

        public bool getConfirmation() { return confirmation; }
        public void setConfirmation(bool confim) { confirmation = confim; }

        //public getter and setter methods to access the private variables
        public float getTax() { return tax; }
        public int getShipping() { return shipping; }

        public int singleChickenCost() { return priceOfSingleChicken; }
        public void setSingleChickenCost(int salePrice) { priceOfSingleChicken = salePrice; }

        public int getID() { return senderId; }
        public void setID(int id) { senderId = id; }

        public int getCardNo() { return cardNo; }
        public void setCardNo(int No) { cardNo = No; }

        public int chickensToBePurchased() { return amount; }
        public void setChickensToBePurchased(int amt) { amount = amt; }

        public DateTime getTimeStamp() { return timeStamp; }
        public void setTimeStamp(DateTime purchaseTime) { timeStamp = purchaseTime.ToUniversalTime(); }
    }
}
