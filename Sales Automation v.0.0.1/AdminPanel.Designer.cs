namespace Sales_Automation_v._0._0._1
{
    partial class AdminPanel
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
            this.lw_adminpanel = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_ProductDelete = new System.Windows.Forms.Button();
            this.lb_name = new System.Windows.Forms.Label();
            this.tb_nameupdate = new System.Windows.Forms.TextBox();
            this.lb_prices = new System.Windows.Forms.Label();
            this.tb_pricesupdate = new System.Windows.Forms.TextBox();
            this.lb_stock = new System.Windows.Forms.Label();
            this.tb_stockupdate = new System.Windows.Forms.TextBox();
            this.lb_weight = new System.Windows.Forms.Label();
            this.tb_weightupdate = new System.Windows.Forms.TextBox();
            this.lg_details = new System.Windows.Forms.Label();
            this.tb_detailsupdate = new System.Windows.Forms.TextBox();
            this.btn_ProductUpdate = new System.Windows.Forms.Button();
            this.btn_addbutton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_item = new System.Windows.Forms.TabPage();
            this.tab_orderhistory = new System.Windows.Forms.TabPage();
            this.lb_orderHistory = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tab_item.SuspendLayout();
            this.tab_orderhistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // lw_adminpanel
            // 
            this.lw_adminpanel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.lw_adminpanel.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lw_adminpanel.FullRowSelect = true;
            this.lw_adminpanel.HideSelection = false;
            this.lw_adminpanel.Location = new System.Drawing.Point(19, 19);
            this.lw_adminpanel.Name = "lw_adminpanel";
            this.lw_adminpanel.Size = new System.Drawing.Size(747, 270);
            this.lw_adminpanel.TabIndex = 0;
            this.lw_adminpanel.UseCompatibleStateImageBehavior = false;
            this.lw_adminpanel.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 142;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Stock";
            this.columnHeader3.Width = 104;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Prices";
            this.columnHeader2.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Weight";
            this.columnHeader4.Width = 133;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Details";
            this.columnHeader5.Width = 119;
            // 
            // btn_ProductDelete
            // 
            this.btn_ProductDelete.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProductDelete.Location = new System.Drawing.Point(60, 344);
            this.btn_ProductDelete.Name = "btn_ProductDelete";
            this.btn_ProductDelete.Size = new System.Drawing.Size(164, 50);
            this.btn_ProductDelete.TabIndex = 1;
            this.btn_ProductDelete.Text = "Product Delete";
            this.btn_ProductDelete.UseVisualStyleBackColor = true;
            this.btn_ProductDelete.Click += new System.EventHandler(this.btn_ProductDelete_Click);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_name.Location = new System.Drawing.Point(819, 49);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(71, 24);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "Name :";
            // 
            // tb_nameupdate
            // 
            this.tb_nameupdate.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_nameupdate.Location = new System.Drawing.Point(976, 44);
            this.tb_nameupdate.Name = "tb_nameupdate";
            this.tb_nameupdate.Size = new System.Drawing.Size(164, 30);
            this.tb_nameupdate.TabIndex = 3;
            // 
            // lb_prices
            // 
            this.lb_prices.AutoSize = true;
            this.lb_prices.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_prices.Location = new System.Drawing.Point(819, 85);
            this.lb_prices.Name = "lb_prices";
            this.lb_prices.Size = new System.Drawing.Size(70, 24);
            this.lb_prices.TabIndex = 2;
            this.lb_prices.Text = "Prices :";
            // 
            // tb_pricesupdate
            // 
            this.tb_pricesupdate.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_pricesupdate.Location = new System.Drawing.Point(976, 80);
            this.tb_pricesupdate.Name = "tb_pricesupdate";
            this.tb_pricesupdate.Size = new System.Drawing.Size(164, 30);
            this.tb_pricesupdate.TabIndex = 3;
            // 
            // lb_stock
            // 
            this.lb_stock.AutoSize = true;
            this.lb_stock.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_stock.Location = new System.Drawing.Point(819, 126);
            this.lb_stock.Name = "lb_stock";
            this.lb_stock.Size = new System.Drawing.Size(67, 24);
            this.lb_stock.TabIndex = 2;
            this.lb_stock.Text = "Stock :";
            // 
            // tb_stockupdate
            // 
            this.tb_stockupdate.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_stockupdate.Location = new System.Drawing.Point(976, 121);
            this.tb_stockupdate.Name = "tb_stockupdate";
            this.tb_stockupdate.Size = new System.Drawing.Size(164, 30);
            this.tb_stockupdate.TabIndex = 3;
            // 
            // lb_weight
            // 
            this.lb_weight.AutoSize = true;
            this.lb_weight.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_weight.Location = new System.Drawing.Point(819, 162);
            this.lb_weight.Name = "lb_weight";
            this.lb_weight.Size = new System.Drawing.Size(82, 24);
            this.lb_weight.TabIndex = 2;
            this.lb_weight.Text = "Weight :";
            // 
            // tb_weightupdate
            // 
            this.tb_weightupdate.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_weightupdate.Location = new System.Drawing.Point(976, 157);
            this.tb_weightupdate.Name = "tb_weightupdate";
            this.tb_weightupdate.Size = new System.Drawing.Size(164, 30);
            this.tb_weightupdate.TabIndex = 3;
            // 
            // lg_details
            // 
            this.lg_details.AutoSize = true;
            this.lg_details.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lg_details.Location = new System.Drawing.Point(819, 198);
            this.lg_details.Name = "lg_details";
            this.lg_details.Size = new System.Drawing.Size(78, 24);
            this.lg_details.TabIndex = 2;
            this.lg_details.Text = "Details :";
            // 
            // tb_detailsupdate
            // 
            this.tb_detailsupdate.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_detailsupdate.Location = new System.Drawing.Point(976, 193);
            this.tb_detailsupdate.Name = "tb_detailsupdate";
            this.tb_detailsupdate.Size = new System.Drawing.Size(164, 30);
            this.tb_detailsupdate.TabIndex = 3;
            // 
            // btn_ProductUpdate
            // 
            this.btn_ProductUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ProductUpdate.Location = new System.Drawing.Point(244, 344);
            this.btn_ProductUpdate.Name = "btn_ProductUpdate";
            this.btn_ProductUpdate.Size = new System.Drawing.Size(164, 50);
            this.btn_ProductUpdate.TabIndex = 4;
            this.btn_ProductUpdate.Text = "Update";
            this.btn_ProductUpdate.UseVisualStyleBackColor = true;
            this.btn_ProductUpdate.Click += new System.EventHandler(this.btn_ProductUpdate_Click);
            // 
            // btn_addbutton
            // 
            this.btn_addbutton.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addbutton.Location = new System.Drawing.Point(427, 344);
            this.btn_addbutton.Name = "btn_addbutton";
            this.btn_addbutton.Size = new System.Drawing.Size(164, 50);
            this.btn_addbutton.TabIndex = 5;
            this.btn_addbutton.Text = "Add Item";
            this.btn_addbutton.UseVisualStyleBackColor = true;
            this.btn_addbutton.Click += new System.EventHandler(this.btn_addbutton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_item);
            this.tabControl1.Controls.Add(this.tab_orderhistory);
            this.tabControl1.Location = new System.Drawing.Point(6, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1210, 509);
            this.tabControl1.TabIndex = 6;
            // 
            // tab_item
            // 
            this.tab_item.BackColor = System.Drawing.SystemColors.Info;
            this.tab_item.Controls.Add(this.lw_adminpanel);
            this.tab_item.Controls.Add(this.tb_pricesupdate);
            this.tab_item.Controls.Add(this.lb_stock);
            this.tab_item.Controls.Add(this.btn_addbutton);
            this.tab_item.Controls.Add(this.lg_details);
            this.tab_item.Controls.Add(this.btn_ProductDelete);
            this.tab_item.Controls.Add(this.tb_weightupdate);
            this.tab_item.Controls.Add(this.lb_name);
            this.tab_item.Controls.Add(this.tb_stockupdate);
            this.tab_item.Controls.Add(this.tb_detailsupdate);
            this.tab_item.Controls.Add(this.btn_ProductUpdate);
            this.tab_item.Controls.Add(this.lb_weight);
            this.tab_item.Controls.Add(this.lb_prices);
            this.tab_item.Controls.Add(this.tb_nameupdate);
            this.tab_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tab_item.Location = new System.Drawing.Point(4, 25);
            this.tab_item.Name = "tab_item";
            this.tab_item.Padding = new System.Windows.Forms.Padding(3);
            this.tab_item.Size = new System.Drawing.Size(1202, 480);
            this.tab_item.TabIndex = 0;
            this.tab_item.Text = "Item";
            this.tab_item.Click += new System.EventHandler(this.tab_item_Click);
            // 
            // tab_orderhistory
            // 
            this.tab_orderhistory.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tab_orderhistory.Controls.Add(this.lb_orderHistory);
            this.tab_orderhistory.Location = new System.Drawing.Point(4, 25);
            this.tab_orderhistory.Name = "tab_orderhistory";
            this.tab_orderhistory.Padding = new System.Windows.Forms.Padding(3);
            this.tab_orderhistory.Size = new System.Drawing.Size(1202, 480);
            this.tab_orderhistory.TabIndex = 1;
            this.tab_orderhistory.Text = "Order History";
            // 
            // lb_orderHistory
            // 
            this.lb_orderHistory.BackColor = System.Drawing.SystemColors.Info;
            this.lb_orderHistory.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_orderHistory.FormattingEnabled = true;
            this.lb_orderHistory.ItemHeight = 23;
            this.lb_orderHistory.Location = new System.Drawing.Point(6, 6);
            this.lb_orderHistory.Name = "lb_orderHistory";
            this.lb_orderHistory.Size = new System.Drawing.Size(1173, 441);
            this.lb_orderHistory.TabIndex = 0;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 532);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_item.ResumeLayout(false);
            this.tab_item.PerformLayout();
            this.tab_orderhistory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lw_adminpanel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_ProductDelete;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_nameupdate;
        private System.Windows.Forms.Label lb_prices;
        private System.Windows.Forms.TextBox tb_pricesupdate;
        private System.Windows.Forms.Label lb_stock;
        private System.Windows.Forms.TextBox tb_stockupdate;
        private System.Windows.Forms.Label lb_weight;
        private System.Windows.Forms.TextBox tb_weightupdate;
        private System.Windows.Forms.Label lg_details;
        private System.Windows.Forms.TextBox tb_detailsupdate;
        private System.Windows.Forms.Button btn_ProductUpdate;
        private System.Windows.Forms.Button btn_addbutton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_item;
        private System.Windows.Forms.TabPage tab_orderhistory;
        private System.Windows.Forms.ListBox lb_orderHistory;
    }
}