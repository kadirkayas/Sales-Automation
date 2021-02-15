using System;
using System.Windows.Forms;

namespace Sales_Automation_v._0._0._1
{
    public partial class OpenPage : Form
    {
        public OpenPage()
        {
            InitializeComponent();
        }
        private void GetForm(Form frm)
        {
            panel2.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frm);
            frm.Show();
        }

        private void OpenPage_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            GetForm(login);
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            GetForm(register);
        }
    }
}
