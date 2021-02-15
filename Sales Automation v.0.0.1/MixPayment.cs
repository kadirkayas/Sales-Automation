using System;
using System.IO;

namespace Sales_Automation_v._0._0._1
{
    public class MixPayment : Payment
    {
        public void mixpayment()
        {
            string TotalOrder = null;
            TotalOrder = orderReader(TotalOrder);
            TotalOrder += " Paymet Metoth Mixed";
            TotalOrder += Environment.NewLine;
            File.AppendAllText("Order.txt", TotalOrder);
        }
    }
}
