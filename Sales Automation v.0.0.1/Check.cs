using System;
using System.IO;

namespace Sales_Automation_v._0._0._1
{
    public class Check:Payment
    {
        public static string Iban { get; set; }
        public static string Accountno { get; set; }
        public void checkpayment()
        {
            string TotalOrder = null;
            TotalOrder = orderReader(TotalOrder);
            TotalOrder += "Paymet Metoth Check +";
            TotalOrder += Check.Iban + "+";
            TotalOrder += Check.Accountno;
            TotalOrder += Environment.NewLine;
            File.AppendAllText("Order.txt", TotalOrder);
        }
    }
}
