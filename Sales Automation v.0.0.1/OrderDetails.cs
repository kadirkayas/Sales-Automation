

namespace Sales_Automation_v._0._0._1
{
   public static class OrderDetails
    {
        private static decimal orderItemWeight;
        public static decimal OrderItemWeight
        {
            get
            {
                return orderItemWeight;
            }
            set
            {
                orderItemWeight = value;
            }
        }

        private static int orderItemQuantity;
        public static int OrderItemQuantity
        {
            get
            {
                return orderItemQuantity;
            }
            set
            {
                orderItemQuantity = value;
            }
        }
        public static decimal orderItemTax;
        public static decimal OrderItemTax
        {
            get
            {
                return orderItemTax;
            }
            set
            {
                orderItemTax = value;
            }
        }
    }
}
