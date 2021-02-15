using System;
using System.IO;

namespace Sales_Automation_v._0._0._1
{
    public static class Item
    {
        //Şeçili ögenin özellikerli
        private static string name;
        public static string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public static decimal prices;
        public static decimal Prices
        {
            get
            {
                return prices;
            }
            set
            {
                prices = value;
            }
        }
        public static int stock;
        public static int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                stock = value;
            }
        }
        private static decimal weight;
        public static decimal Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public static string details;
        public static string Details
        {
            get
            {
                return details;
            }
            set
            {
                details = value;
            }
        }
        //Seçili combobax ögesinin verilerini ayrıştırır ve değerleri eşitler
        public static string itemdetails(string combobox)
        {
            StreamReader ItemDataText = new StreamReader(System.Windows.Forms.Application.StartupPath + "\\Item.txt");
            string line, text;
            text = combobox;
            string send = null;
            while ((line = ItemDataText.ReadLine()) != null)
            {
                string itemName = null, itemStock = null, itemPrices = null, itemWeight = null, itemDetails = null;
                int plus = 0;
                for (int j = 0; j < line.Length - 1; j++)
                {
                    if (line[j] == '+')
                    {
                        plus++;
                    }
                    else if (plus == 0)
                    {
                        itemName = itemName + line[j];
                    }
                    else if (plus == 1)
                    {
                        itemStock = itemStock + line[j];
                    }
                    else if (plus == 2)
                    {
                        itemPrices = itemPrices + line[j];
                    }
                    else if (plus == 3)
                    {
                        itemWeight = itemWeight + line[j];
                    }
                    else if (plus == 4)
                    {
                        itemDetails = itemDetails + line[j];
                    }
                }
                if (itemName == text)
                {
                    send = itemName + "+" + itemStock;
                    name = itemName;
                    stock = Convert.ToInt32(itemStock);
                    prices = Convert.ToDecimal(itemPrices);
                    weight = Convert.ToDecimal(itemWeight);
                    details = itemDetails;
                }
            }
            ItemDataText.Close();
            return send;
        }
    }
}
