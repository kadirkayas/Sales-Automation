using System;
using System.IO;

namespace Sales_Automation_v._0._0._1
{
    public class Cash : Payment
    {
        public void cashpayment()
        {
            string TotalOrder = null;
            TotalOrder = orderReader(TotalOrder);
            TotalOrder += "Paymet Metoth Cash";
            TotalOrder += Environment.NewLine;
            File.AppendAllText("Order.txt", TotalOrder);
        }
    }
}
