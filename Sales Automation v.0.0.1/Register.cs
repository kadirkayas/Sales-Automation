using System;
using System.Windows.Forms;
using System.IO;

namespace Sales_Automation_v._0._0._1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        //Kayıt olmayı sağlamak için
        private void btn_Register_Click(object sender, EventArgs e)
        {
            string name = tb_Name.Text,
            surname = tb_Name.Text, 
            userID = tb_UserID.Text,
            password = tb_Password.Text,
            repassword = tb_Repassword.Text,
            adress = tb_Adress.Text;
            //kullanıcının textboxları boş bırakıp bırakmadığını kontrol eder
            if (name == "" || name == null ||
                surname == "" || surname == null ||
                userID == "" || userID == null ||
                password == "" || password == null ||
                repassword == "" || repassword == null ||
                adress == "" || adress == null)
            {
                MessageBox.Show("Fill In All Blank Fields");
            }
            //Şifrelerin ulaşıp ulaşmadığını kontrol etmek için kullanılır
            else if (repassword != password)
            {
                MessageBox.Show("Passwords Do Not Match");
            }
            else
            {
                Customer user = new Customer();
                bool control = user.userregister(userID);
                if (control == true)
                {   //Kullanıcının verisini text dosyasına kaydeder
                    string newUser = name + "+" + surname + "+" + userID + "+" + password + "+" + adress + Environment.NewLine;
                    File.AppendAllText("UserData.txt", newUser);
                    MessageBox.Show("User registered");
                    //Text boxdaki yazıları temizlemek için
                    tb_Name.Text = "";
                    tb_Surname.Text = "";
                    tb_UserID.Text = "";
                    tb_Password.Text = "";
                    tb_Repassword.Text = "";
                    tb_Adress.Text = "";
                }
            }
        }
    }
}
