using System;
using System.IO;

namespace Sales_Automation_v._0._0._1
{
    public class Credit : Payment
    {
        
        protected static string creditcartno;
        public static string Creditcartno
        {
            get
            {
                return creditcartno;
            }
            set
            {
                creditcartno = value;
            }
        }
        public static string expdate { get; set; }
        public void creditpayment()
        {
            string TotalOrder = null;
            TotalOrder = orderReader(TotalOrder);
            TotalOrder += "paymet metoth credit +";
            TotalOrder += Credit.Creditcartno + "+";
            TotalOrder += Credit.expdate + "+";
            TotalOrder += Environment.NewLine;
            File.AppendAllText("Order.txt", TotalOrder);
        }
    }
}
