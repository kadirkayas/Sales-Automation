using System;

namespace Sales_Automation_v._0._0._1
{
    public class Payment
    {
        public static string PaymentProductName { get; set; }
        public static int PaymentProductQuantity { get; set; }
        public static decimal PaymentTotalPrices { get; set; }

        public string orderReader(string total)
        {
            DateTime date = DateTime.Now;
            string TotalOrder = null;
            TotalOrder += Cash.PaymentProductName + "+";
            TotalOrder += Cash.PaymentProductQuantity + "+";
            TotalOrder += Cash.PaymentTotalPrices + "+";
            TotalOrder += Order.CalcTotalWeight + "+";
            TotalOrder += Order.CalcTotalTax + "+";
            TotalOrder += Customer.Name + "+";
            TotalOrder += Customer.Adress + "+";
            TotalOrder += date + "+";
            return TotalOrder;
        }
    }
}
