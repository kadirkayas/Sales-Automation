namespace Sales_Automation_v._0._0._1
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_UserIDLogin = new System.Windows.Forms.TextBox();
            this.tb_PasswordLogin = new System.Windows.Forms.TextBox();
            this.lb_UserID = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_UserIDLogin
            // 
            this.tb_UserIDLogin.Location = new System.Drawing.Point(181, 66);
            this.tb_UserIDLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_UserIDLogin.Name = "tb_UserIDLogin";
            this.tb_UserIDLogin.Size = new System.Drawing.Size(242, 28);
            this.tb_UserIDLogin.TabIndex = 0;
            this.tb_UserIDLogin.Text = "admin";
            // 
            // tb_PasswordLogin
            // 
            this.tb_PasswordLogin.Location = new System.Drawing.Point(181, 102);
            this.tb_PasswordLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_PasswordLogin.Name = "tb_PasswordLogin";
            this.tb_PasswordLogin.Size = new System.Drawing.Size(242, 28);
            this.tb_PasswordLogin.TabIndex = 1;
            this.tb_PasswordLogin.Text = "admin";
            this.tb_PasswordLogin.UseSystemPasswordChar = true;
            // 
            // lb_UserID
            // 
            this.lb_UserID.AutoSize = true;
            this.lb_UserID.Location = new System.Drawing.Point(37, 71);
            this.lb_UserID.Name = "lb_UserID";
            this.lb_UserID.Size = new System.Drawing.Size(73, 23);
            this.lb_UserID.TabIndex = 2;
            this.lb_UserID.Text = "User ID :";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(37, 105);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(94, 23);
            this.lb_Password.TabIndex = 3;
            this.lb_Password.Text = "Password :";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Login.ForeColor = System.Drawing.Color.Gray;
            this.btn_Login.Location = new System.Drawing.Point(181, 137);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(242, 50);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(538, 289);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_UserID);
            this.Controls.Add(this.tb_PasswordLogin);
            this.Controls.Add(this.tb_UserIDLogin);
            this.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_UserIDLogin;
        private System.Windows.Forms.TextBox tb_PasswordLogin;
        private System.Windows.Forms.Label lb_UserID;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Button btn_Login;
    }
}