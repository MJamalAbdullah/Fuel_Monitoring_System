namespace Final_Project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logopannel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menupannel = new System.Windows.Forms.Panel();
            this.settingbtn = new System.Windows.Forms.Button();
            this.empbtn = new System.Windows.Forms.Button();
            this.addproductbtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.stockbtn = new System.Windows.Forms.Button();
            this.bankbtn = new System.Windows.Forms.Button();
            this.purchasebtn = new System.Windows.Forms.Button();
            this.salesbtn = new System.Windows.Forms.Button();
            this.menupannelbot = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.homebtn = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.viewpannel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.logopannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menupannel.SuspendLayout();
            this.menupannelbot.SuspendLayout();
            this.viewpannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // logopannel
            // 
            this.logopannel.BackColor = System.Drawing.Color.White;
            this.logopannel.Controls.Add(this.pictureBox2);
            this.logopannel.Location = new System.Drawing.Point(0, -1);
            this.logopannel.Name = "logopannel";
            this.logopannel.Size = new System.Drawing.Size(164, 127);
            this.logopannel.TabIndex = 0;
            this.logopannel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_Project.Properties.Resources.ceypetco_logo;
            this.pictureBox2.Location = new System.Drawing.Point(21, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // menupannel
            // 
            this.menupannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(37)))), ((int)(((byte)(29)))));
            this.menupannel.Controls.Add(this.settingbtn);
            this.menupannel.Controls.Add(this.empbtn);
            this.menupannel.Controls.Add(this.addproductbtn);
            this.menupannel.Controls.Add(this.searchbtn);
            this.menupannel.Controls.Add(this.stockbtn);
            this.menupannel.Controls.Add(this.bankbtn);
            this.menupannel.Controls.Add(this.purchasebtn);
            this.menupannel.Controls.Add(this.salesbtn);
            this.menupannel.Controls.Add(this.logopannel);
            this.menupannel.Location = new System.Drawing.Point(1, 0);
            this.menupannel.Name = "menupannel";
            this.menupannel.Size = new System.Drawing.Size(885, 120);
            this.menupannel.TabIndex = 0;
            // 
            // settingbtn
            // 
            this.settingbtn.FlatAppearance.BorderSize = 0;
            this.settingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingbtn.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingbtn.ForeColor = System.Drawing.Color.White;
            this.settingbtn.Image = global::Final_Project.Properties.Resources.setting;
            this.settingbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingbtn.Location = new System.Drawing.Point(702, 60);
            this.settingbtn.Name = "settingbtn";
            this.settingbtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.settingbtn.Size = new System.Drawing.Size(181, 60);
            this.settingbtn.TabIndex = 8;
            this.settingbtn.Text = "Setting ";
            this.settingbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingbtn.UseVisualStyleBackColor = true;
            this.settingbtn.Click += new System.EventHandler(this.settingbtn_Click);
            // 
            // empbtn
            // 
            this.empbtn.FlatAppearance.BorderSize = 0;
            this.empbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empbtn.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empbtn.ForeColor = System.Drawing.Color.White;
            this.empbtn.Image = global::Final_Project.Properties.Resources.emp;
            this.empbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.empbtn.Location = new System.Drawing.Point(522, 60);
            this.empbtn.Name = "empbtn";
            this.empbtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.empbtn.Size = new System.Drawing.Size(181, 60);
            this.empbtn.TabIndex = 7;
            this.empbtn.Text = "Employee ";
            this.empbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.empbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.empbtn.UseVisualStyleBackColor = true;
            this.empbtn.Click += new System.EventHandler(this.empbtn_Click);
            // 
            // addproductbtn
            // 
            this.addproductbtn.FlatAppearance.BorderSize = 0;
            this.addproductbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addproductbtn.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addproductbtn.ForeColor = System.Drawing.Color.White;
            this.addproductbtn.Image = global::Final_Project.Properties.Resources.Add_product;
            this.addproductbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addproductbtn.Location = new System.Drawing.Point(342, 60);
            this.addproductbtn.Name = "addproductbtn";
            this.addproductbtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.addproductbtn.Size = new System.Drawing.Size(181, 60);
            this.addproductbtn.TabIndex = 6;
            this.addproductbtn.Text = "Add Product ";
            this.addproductbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addproductbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addproductbtn.UseVisualStyleBackColor = true;
            this.addproductbtn.Click += new System.EventHandler(this.addproductbtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.FlatAppearance.BorderSize = 0;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.Color.White;
            this.searchbtn.Image = global::Final_Project.Properties.Resources.search;
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchbtn.Location = new System.Drawing.Point(703, 0);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.searchbtn.Size = new System.Drawing.Size(181, 60);
            this.searchbtn.TabIndex = 9;
            this.searchbtn.Text = "Search";
            this.searchbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // stockbtn
            // 
            this.stockbtn.FlatAppearance.BorderSize = 0;
            this.stockbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stockbtn.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockbtn.ForeColor = System.Drawing.Color.White;
            this.stockbtn.Image = global::Final_Project.Properties.Resources.stock;
            this.stockbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockbtn.Location = new System.Drawing.Point(161, 60);
            this.stockbtn.Name = "stockbtn";
            this.stockbtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.stockbtn.Size = new System.Drawing.Size(181, 60);
            this.stockbtn.TabIndex = 4;
            this.stockbtn.Text = "Stock";
            this.stockbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stockbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.stockbtn.UseVisualStyleBackColor = true;
            this.stockbtn.Click += new System.EventHandler(this.stockbtn_Click);
            // 
            // bankbtn
            // 
            this.bankbtn.FlatAppearance.BorderSize = 0;
            this.bankbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bankbtn.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bankbtn.ForeColor = System.Drawing.Color.White;
            this.bankbtn.Image = global::Final_Project.Properties.Resources.bank;
            this.bankbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bankbtn.Location = new System.Drawing.Point(522, 0);
            this.bankbtn.Name = "bankbtn";
            this.bankbtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.bankbtn.Size = new System.Drawing.Size(181, 60);
            this.bankbtn.TabIndex = 3;
            this.bankbtn.Text = "Bank";
            this.bankbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bankbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bankbtn.UseVisualStyleBackColor = true;
            this.bankbtn.Click += new System.EventHandler(this.bankbtn_Click);
            // 
            // purchasebtn
            // 
            this.purchasebtn.FlatAppearance.BorderSize = 0;
            this.purchasebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchasebtn.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasebtn.ForeColor = System.Drawing.Color.White;
            this.purchasebtn.Image = global::Final_Project.Properties.Resources.invoice;
            this.purchasebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.purchasebtn.Location = new System.Drawing.Point(342, 0);
            this.purchasebtn.Name = "purchasebtn";
            this.purchasebtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.purchasebtn.Size = new System.Drawing.Size(181, 60);
            this.purchasebtn.TabIndex = 2;
            this.purchasebtn.Text = "Purchase ";
            this.purchasebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.purchasebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.purchasebtn.UseVisualStyleBackColor = true;
            this.purchasebtn.Click += new System.EventHandler(this.purchasebtn_Click);
            // 
            // salesbtn
            // 
            this.salesbtn.FlatAppearance.BorderSize = 0;
            this.salesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesbtn.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesbtn.ForeColor = System.Drawing.Color.White;
            this.salesbtn.Image = global::Final_Project.Properties.Resources.Sales;
            this.salesbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesbtn.Location = new System.Drawing.Point(161, 0);
            this.salesbtn.Name = "salesbtn";
            this.salesbtn.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.salesbtn.Size = new System.Drawing.Size(181, 60);
            this.salesbtn.TabIndex = 1;
            this.salesbtn.Text = "Sale\'s";
            this.salesbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salesbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.salesbtn.UseVisualStyleBackColor = true;
            this.salesbtn.Click += new System.EventHandler(this.salesbtn_Click);
            // 
            // menupannelbot
            // 
            this.menupannelbot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(37)))), ((int)(((byte)(29)))));
            this.menupannelbot.Controls.Add(this.logout);
            this.menupannelbot.Controls.Add(this.homebtn);
            this.menupannelbot.Controls.Add(this.time);
            this.menupannelbot.Controls.Add(this.date);
            this.menupannelbot.Location = new System.Drawing.Point(-1, 537);
            this.menupannelbot.Name = "menupannelbot";
            this.menupannelbot.Size = new System.Drawing.Size(887, 45);
            this.menupannelbot.TabIndex = 2;
            // 
            // logout
            // 
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Image = global::Final_Project.Properties.Resources.logout1;
            this.logout.Location = new System.Drawing.Point(816, 5);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(66, 35);
            this.logout.TabIndex = 15;
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // homebtn
            // 
            this.homebtn.FlatAppearance.BorderSize = 0;
            this.homebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebtn.Image = global::Final_Project.Properties.Resources.home_white;
            this.homebtn.Location = new System.Drawing.Point(705, 5);
            this.homebtn.Name = "homebtn";
            this.homebtn.Size = new System.Drawing.Size(66, 35);
            this.homebtn.TabIndex = 14;
            this.homebtn.UseVisualStyleBackColor = true;
            this.homebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(340, 11);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(55, 22);
            this.time.TabIndex = 12;
            this.time.Text = "Time";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(19, 11);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(54, 22);
            this.date.TabIndex = 11;
            this.date.Text = "Date ";
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // viewpannel
            // 
            this.viewpannel.Controls.Add(this.pictureBox3);
            this.viewpannel.Location = new System.Drawing.Point(0, 120);
            this.viewpannel.Name = "viewpannel";
            this.viewpannel.Size = new System.Drawing.Size(886, 417);
            this.viewpannel.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Final_Project.Properties.Resources._7;
            this.pictureBox3.Location = new System.Drawing.Point(1, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(882, 415);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // notify
            // 
            this.notify.Text = "notifyIcon1";
            this.notify.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 579);
            this.Controls.Add(this.viewpannel);
            this.Controls.Add(this.menupannelbot);
            this.Controls.Add(this.menupannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Furl Monitoring";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.logopannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menupannel.ResumeLayout(false);
            this.menupannelbot.ResumeLayout(false);
            this.menupannelbot.PerformLayout();
            this.viewpannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel logopannel;
        private System.Windows.Forms.Button salesbtn;
        private System.Windows.Forms.Button purchasebtn;
        private System.Windows.Forms.Button bankbtn;
        private System.Windows.Forms.Button stockbtn;
        private System.Windows.Forms.Button addproductbtn;
        private System.Windows.Forms.Button empbtn;
        private System.Windows.Forms.Button settingbtn;
        private System.Windows.Forms.Panel menupannel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel menupannelbot;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel viewpannel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button homebtn;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.NotifyIcon notify;

    }
}

