using System;
using System.Windows.Forms;
using System.IO;

namespace Sales_Automation_v._0._0._1
{
    public partial class Application : Form
    {
        public Application()
        {
            InitializeComponent();
        }
        decimal total = Payment.PaymentTotalPrices;
        private void Application_Load(object sender, EventArgs e)
        {
            StreamReader ItemDataText = new StreamReader(System.Windows.Forms.Application.StartupPath + "\\Item.txt");
            string line = null;
            while ((line = ItemDataText.ReadLine()) != null)
            {
                string getItemName = null;
                int plus = 0;
                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] == '+')
                    {
                        plus++;
                    }
                    else if (plus == 0)
                    {
                        getItemName = getItemName + line[j];
                    }
                }
                cb_ItemSelect.Items.Add(getItemName);
            }
            ItemDataText.Close();

            //mix i 0 lamak için
            tb_paymixchecpayamount.Text = tb_paymixcreditamount.Text = tb_paymixcashaccount.Text = 0.ToString();
        }
        //comboboxtaki öge değişirse değişen ögenin verilerini özellikler kısmına atmak için
        private void cb_ItemSelect_TextChanged(object sender, EventArgs e)
        {
            string yazilacak = Item.itemdetails(cb_ItemSelect.Text);
            lb_products.Text = Item.Name;
            lb_priced.Text = Item.prices.ToString();
            lb_stockq.Text = Item.stock.ToString();
            lb_detailsd.Text = Item.details;
            nud_quantity.Maximum = Convert.ToInt32(Item.stock);
        }
        private void btn_addlist_Click(object sender, EventArgs e)
        {
            //emire gidenler
            OrderDetails.OrderItemWeight += Item.Weight;
            OrderDetails.OrderItemQuantity += Convert.ToInt32(nud_quantity.Value);
            OrderDetails.orderItemTax += Item.prices * 18 / 100;
            Order.CalcTotalPrices = Item.prices * OrderDetails.OrderItemQuantity;
            Order.CalcTotalTax = OrderDetails.orderItemTax * OrderDetails.OrderItemQuantity;
            Order.CalcTotalWeight = OrderDetails.OrderItemWeight * OrderDetails.OrderItemQuantity;
            //ödemeye giden veriler
            Payment.PaymentProductName = Item.Name;
            Payment.PaymentProductQuantity = OrderDetails.OrderItemQuantity;
            Payment.PaymentTotalPrices = Order.CalcTotalPrices;
            //ürünü listeye ekleyenler
            ListViewItem orderAdd = new ListViewItem(Payment.PaymentProductName);
            orderAdd.SubItems.Add(Payment.PaymentProductQuantity.ToString());
            orderAdd.SubItems.Add(Payment.PaymentTotalPrices.ToString());
            lw_payments.Items.Add(orderAdd);
            //toplam fiyatı hesaplayanlar
            total = Convert.ToDecimal(lb_totalprices.Text) + Payment.PaymentTotalPrices;
            lb_totalprices.Text = total.ToString();
            lb_totalpaymentcash.Text = total.ToString();
            lb_totalpaymentcheck.Text = total.ToString();
            lb_totalpaymentcredit.Text = total.ToString();
            lb_totalpaymentmix.Text = total.ToString();
        }

        // ürün seçilirken miktar 0 ise sepete ekleme yapmaması için buttonu kapatır
        private void nud_quantity_ValueChanged(object sender, EventArgs e)
        {
            if (nud_quantity.Value > 0)
            {
                btn_addlist.Enabled = true;
            }
            else if (nud_quantity.Value == 0)
            {
                btn_addlist.Enabled = false;
            }
        }
        //listedeki ürünleri siler
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lw_payments.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectitem in lw_payments.SelectedItems)
                {
                    total = total - Convert.ToDecimal(lw_payments.SelectedItems[0].SubItems[2].Text);
                    lb_totalprices.Text = total.ToString();
                    lb_totalprices.Text = total.ToString();
                    lb_totalpaymentcash.Text = total.ToString();
                    lb_totalpaymentcheck.Text = total.ToString();
                    lb_totalpaymentcredit.Text = total.ToString();
                    lb_totalpaymentmix.Text = total.ToString();
                    selectitem.Remove();
                }
            }
        }
        //mix ödemede kredi kartı ile ödeme yaparken paneli açıp kapatma
        private void cbx_creditpaymet_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_creditpaymet.Checked == true)
            {
                pnl_credit.Enabled = true;
            }
            else
            {
                pnl_credit.Enabled = false;
            }
        }
        //mix ödemede check ile ödeme yaparken paneli açıp kapatma
        private void cbx_checkpaymets_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_checkpaymets.Checked == true)
            {
                pnl_chech.Enabled = true;
            }
            else
            {
                pnl_chech.Enabled = false;
            }
        }
        //mix ödemede nakit ile ödeme yaparken paneli açıp kapatma
        private void cbx_cashpayment_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_cashpayment.Checked == true)
            {
                pnl_cash.Enabled = true;
            }
            else
            {
                pnl_cash.Enabled = false;
            }
        }
        //nakit ödeme buttonu
        private void btn_CashPayment_Click(object sender, EventArgs e)
        {
            total = 0;
            lb_totalpaymentmix.Text = lb_totalpaymentcredit.Text = lb_totalpaymentcheck.Text =
                lb_totalpaymentcash.Text = lb_totalprices.Text = lb_totalprices.Text = total.ToString();
            lw_payments.Items.Clear();
            MessageBox.Show("Succesful Packet Send Home");
            Cash cash = new Cash();
            cash.cashpayment();
        }
        //kredi kartı ödeme buttonu
        private void btn_creditPayment_Click(object sender, EventArgs e)
        {
            bool control = true;
            control = TextController.TextControlMethod(tb_accountnamecredit.Text);
            control = TextController.TextControlMethod(tb_cvv.Text);
            if (control == true)
            {
                if (tb_accountnamecredit.TextLength == 16 &&
                    cb_cartdatemont.Text != null &&
                    cb_cartdateyears.Text != null &&
                    tb_cvv.TextLength == 3
                    )
                {
                    Credit credit = new Credit();
                    Credit.Creditcartno = tb_accountnamecredit.Text;
                    Credit.expdate = cb_cartdatemont.Text + "/" + cb_cartdateyears.Text;
                    credit.creditpayment();
                    total = 0;
                    lb_totalpaymentmix.Text = lb_totalpaymentcredit.Text = lb_totalpaymentcheck.Text =
                     lb_totalpaymentcash.Text = lb_totalprices.Text = lb_totalprices.Text = total.ToString();
                    lw_payments.Items.Clear();
                    MessageBox.Show("Succesful Packet Send Home");
                    tb_accountnamecredit.Text = cb_cartdatemont.Text = cb_cartdateyears.Text = tb_cvv.Text = null;
                }
                else
                {
                    MessageBox.Show("Please Enter a Valid Value");
                }
            }
        }
        //check ödeme buttonu
        private void btn_ChechPayment_Click(object sender, EventArgs e)
        {
            bool control = true;
            control = TextController.TextControlMethod(tb_ibanno.Text);
            control = TextController.TextControlMethod(tb_accountnocheck.Text);
            if (tb_ibanno.TextLength == 26 &&
                tb_accountnocheck.TextLength == 16
               )
            {
                Check check = new Check();
                Check.Iban = tb_ibanno.Text;
                Check.Accountno = tb_accountnocheck.Text;
                check.checkpayment();
                total = 0;
                lb_totalpaymentmix.Text = lb_totalpaymentcredit.Text = lb_totalpaymentcheck.Text =
                    lb_totalpaymentcash.Text = lb_totalprices.Text = lb_totalprices.Text = total.ToString();
                lw_payments.Items.Clear();
                MessageBox.Show("Succesful Packet Send Home");
                tb_ibanno.Text = tb_accountnocheck.Text = null;
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Value");
            }
        }
        //Mix ödeme buttonu
        private void btn_mixpayment_Click(object sender, EventArgs e)
        {
            bool bolma = true;
            decimal payment = 0;
            if ((Convert.ToDecimal(tb_paymixcashaccount.Text) +
                Convert.ToDecimal(tb_paymixcreditamount.Text) +
               Convert.ToDecimal(tb_paymixchecpayamount.Text) == total))
            {
                //Mix ödeme yaparken nakit çekecek kısım
                if (cbx_cashpayment.Checked == true)
                {
                    total = 0;
                    lb_totalpaymentmix.Text = lb_totalpaymentcredit.Text = lb_totalpaymentcheck.Text =
                        lb_totalpaymentcash.Text = lb_totalprices.Text = lb_totalprices.Text = total.ToString();
                    payment += Convert.ToDecimal(tb_paymixcashaccount.Text);
                    lw_payments.Items.Clear();
                }
                //Mix kredi kartından çekeçek kısım
                if (cbx_creditpaymet.Checked == true)
                {
                    bool control = true;
                    control = TextController.TextControlMethod(tb_paymixcreditaccountno.Text);
                    control = TextController.TextControlMethod(tb_paymixcreditcvv.Text);
                    if (control == true)
                    {
                        if (tb_paymixcreditaccountno.TextLength == 16 &&
                        cb_cartdateyearsmix.Text != null &&
                        cb_cartdatemontmix.Text != null &&
                        tb_paymixcreditcvv.TextLength == 3
                        )
                        {
                            MixPayment mix = new MixPayment();
                            mix.mixpayment();
                            total = 0;
                            lb_totalpaymentmix.Text = lb_totalpaymentcredit.Text = lb_totalpaymentcheck.Text =
                                lb_totalpaymentcash.Text = lb_totalprices.Text = lb_totalprices.Text = total.ToString();
                            lw_payments.Items.Clear();
                            payment += Convert.ToDecimal(tb_paymixcreditamount.Text); ;
                            tb_paymixcreditamount.Text = tb_paymixcreditaccountno.Text = cb_cartdatemontmix.Text =
                                cb_cartdateyearsmix.Text = tb_paymixcreditcvv.Text = null;
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Valid Value");
                            bolma = false;
                        }
                    }
                }
                //Mix ödeme yaparken check ödeme lısmı
                if (cbx_checkpaymets.Checked == true)
                {
                    bool control = true;
                    control = TextController.TextControlMethod(tb_paymixcheckibanno.Text);
                    control = TextController.TextControlMethod(tb_paymixchecpayamountno.Text);
                    if (control == true)
                    {
                        if (tb_paymixcheckibanno.TextLength == 26 &&
                     tb_paymixchecpayamountno.TextLength == 16)
                        {
                            total = 0;
                            lb_totalpaymentmix.Text = lb_totalpaymentcredit.Text = lb_totalpaymentcheck.Text =
                                lb_totalpaymentcash.Text = lb_totalprices.Text = lb_totalprices.Text = total.ToString();
                            lw_payments.Items.Clear();
                            payment += Convert.ToDecimal(tb_paymixchecpayamount.Text);
                            tb_paymixchecpayamount.Text = tb_paymixcheckibanno.Text = tb_paymixchecpayamountno.Text = null;
                        }
                        else
                        {
                            bolma = false;
                            MessageBox.Show("Please Enter a Valid Value");
                        }
                    }
                }
                if (bolma == true)
                {
                    MessageBox.Show("Payment okey");
                }
            }
            else
            {
                MessageBox.Show("Enter the correct amount");
            }
        }
    }
}


