using System;
using System.Windows.Forms;
using System.IO;

namespace Sales_Automation_v._0._0._1
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        //item listesi güncelleme fonksiyonu
        private void listupdater()
        {
            StreamReader ItemDataText = new StreamReader(System.Windows.Forms.Application.StartupPath + "\\Item.txt");
            string line;
            string[] Reader = new string[5];
            while ((line = ItemDataText.ReadLine()) != null)
            {
                int plus = 0;
                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] == '+')
                    {
                        plus++;
                    }
                    else if (plus == 0)
                    {
                        Reader[0] = Reader[0] + line[j].ToString();
                    }
                    else if (plus == 1)
                    {
                        Reader[1] = Reader[1] + line[j].ToString();
                    }
                    else if (plus == 2)
                    {
                        Reader[2] = Reader[2] + line[j].ToString();
                    }
                    else if (plus == 3)
                    {
                        Reader[3] = Reader[3] + line[j].ToString();
                    }
                    else if (plus == 4)
                    {
                        Reader[4] = Reader[4] + line[j].ToString();
                    }
                }
                ListViewItem AdminPanelReader = new ListViewItem(Reader);
                lw_adminpanel.Items.Add(AdminPanelReader);
                for (int i = 0; i < 5; i++)
                {
                    Reader[i] = null;
                }
            }
            ItemDataText.Close();
        }
        //sipariş kayıtlarını yükler
        private void orderloader()
        {
            StreamReader OrderHistory = new StreamReader(System.Windows.Forms.Application.StartupPath + "\\Order.txt");
            string line;
            while ((line = OrderHistory.ReadLine()) != null)
            {
                string eklenecek = null;
                for (int j = 0; j < line.Length - 1; j++)
                {
                    if (line[j] != '+')
                    {
                        eklenecek += line[j];
                    }
                    else
                    {
                        eklenecek += " ";
                    }
                }
                lb_orderHistory.Items.Add(eklenecek);
            }
            OrderHistory.Close();
        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            listupdater();
            orderloader();
        }
        private void delete()
        {
            string readdelete = null;
            //seçili itemi listeden siler
            foreach (ListViewItem selectitem in lw_adminpanel.SelectedItems)
            {
                selectitem.Remove();
            }
            if (lw_adminpanel.Items.Count > 0)
            {
                //item klasörünü siler sonra yeniden açar
                if (File.Exists("Item.txt"))
                {
                    File.Delete("Item.txt");
                }
                FileStream fs = File.Create("Item.txt");
                fs.Close();
                //listedeki ürünleri item klasörüne tekrardan yazar
                foreach (ListViewItem item in lw_adminpanel.Items)
                {
                    readdelete = item.SubItems[0].Text + "+"
                       + item.SubItems[1].Text + "+"
                       + item.SubItems[2].Text + "+"
                       + item.SubItems[3].Text + "+"
                       + item.SubItems[4].Text
                       + Environment.NewLine;
                    File.AppendAllText("Item.txt", readdelete);
                }
            }
        }
        //admin için seçilen itemi silme butonu
        private void btn_ProductDelete_Click(object sender, EventArgs e)
        {
            delete();
        }
        //admin için seçilen ürün güncelleme
        private void btn_ProductUpdate_Click(object sender, EventArgs e)
        {
            bool Total = true;
            Total = TextController.TextControlMethod(tb_pricesupdate.Text);
            Total = TextController.TextControlMethod(tb_stockupdate.Text);
            Total = TextController.TextControlMethod(tb_weightupdate.Text);
            if (Total == true)
            {
                if (tb_nameupdate.Text == "" || tb_nameupdate.Text == null ||
                tb_pricesupdate.Text == "" || tb_pricesupdate.Text == null ||
                tb_stockupdate.Text == "" || tb_stockupdate.Text == null ||
                tb_weightupdate.Text == "" || tb_weightupdate.Text == null ||
                tb_detailsupdate.Text == "" || tb_detailsupdate.Text == null)
                {
                    MessageBox.Show("Fill In All Blank Fields");
                }
                else
                {
                    delete();
                    string add = null;
                    add += tb_nameupdate.Text + "+" + tb_pricesupdate.Text + "+" + tb_stockupdate.Text + "+" + tb_stockupdate.Text + "+" + tb_detailsupdate.Text + Environment.NewLine;
                    File.AppendAllText("Item.txt", add);
                    lw_adminpanel.Items.Clear();
                    listupdater();
                }
            }
        }
        //admin için ürün ekleme butonu
        private void btn_addbutton_Click(object sender, EventArgs e)
        {
            bool Total = true;
            Total = TextController.TextControlMethod(tb_pricesupdate.Text);
            Total = TextController.TextControlMethod(tb_stockupdate.Text);
            Total = TextController.TextControlMethod(tb_weightupdate.Text);
            if (Total == true)
            {
                if (tb_nameupdate.Text == "" || tb_nameupdate.Text == null ||
                    tb_pricesupdate.Text == "" || tb_pricesupdate.Text == null ||
                    tb_stockupdate.Text == "" || tb_stockupdate.Text == null ||
                    tb_weightupdate.Text == "" || tb_weightupdate.Text == null ||
                    tb_detailsupdate.Text == "" || tb_detailsupdate.Text == null)
                {
                    MessageBox.Show("Fill In All Blank Fields");
                }
                else
                {
                    string add = null;
                    add += tb_nameupdate.Text + "+" + tb_pricesupdate.Text + "+" + tb_stockupdate.Text + "+" + tb_stockupdate.Text + "+" + tb_detailsupdate.Text + Environment.NewLine;
                    File.AppendAllText("Item.txt", add);
                    lw_adminpanel.Items.Clear();
                    listupdater();
                }
            }
        }
        private void tab_item_Click(object sender, EventArgs e)
        {

        }
    }
}