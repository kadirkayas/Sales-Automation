using System;
using System.Windows.Forms;

namespace Sales_Automation_v._0._0._1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Giriş yapmayı sağlamak için 
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if ("admin" == tb_UserIDLogin.Text && "admin" == tb_PasswordLogin.Text)
            {
                MessageBox.Show("Admin Welcome ");
                AdminPanel admin = new AdminPanel();
                admin.Show();
            }
            else
            {
                Customer user = new Customer();
                string line = user.userlogin(tb_UserIDLogin.Text, tb_PasswordLogin.Text);
                string getUserID = null, getPassword = null, getLine = line;
                int plus = 0;
                for (int j = 0; j < getLine.Length; j++)
                {
                    if (getLine[j] == '+')
                    {
                        plus++;
                    }
                    else if (plus == 2)
                    {
                        getUserID = getUserID + getLine[j];
                    }
                    else if (plus == 3)
                    {
                        getPassword = getPassword + getLine[j];
                    }
                }
                if (getUserID == tb_UserIDLogin.Text && getPassword == tb_PasswordLogin.Text)
                {
                    MessageBox.Show("Welcome");
                    Application Applicationform = new Application();
                    Applicationform.Show();
                    this.Hide();
                }
            }
        }

    }
}
