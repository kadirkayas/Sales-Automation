using System;
using System.Windows.Forms;

namespace Sales_Automation_v._0._0._1
{
    public static class TextController
    {
        //textboxlara girilen değerin sayı olup olmadığını kontrol editor
        public static bool TextControlMethod(string text)
        {
            bool firstcontrol = true;
            foreach (char character in text)
            {
                try
                {
                    int.Parse(text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Enter a Numeric Value");
                    firstcontrol = false;
                    break;
                }
            }
            return firstcontrol;
        }
    }
}
