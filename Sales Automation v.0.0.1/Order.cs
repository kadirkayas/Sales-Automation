
namespace Sales_Automation_v._0._0._1
{
    public static class Order
    {
        private static decimal calcTotalWeight;
        public static decimal CalcTotalWeight
        {
            get
            {
                return calcTotalWeight;
            }
            set
            {
                calcTotalWeight = value;
            }
        }
        private static decimal calcTotalTax;
        public static decimal CalcTotalTax
        {
            get
            {
                return calcTotalTax;
            }
            set
            {
                calcTotalTax = value;
            }
        }
        private static decimal calcTotalPrices;
        public static decimal CalcTotalPrices
        {
            get
            {
                return calcTotalPrices;
            }
            set
            {
                calcTotalPrices = value;
            }
        }

    }
}
