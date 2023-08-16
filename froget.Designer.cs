namespace Final_Project
{
    partial class froget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(froget));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uid = new System.Windows.Forms.TextBox();
            this.nwp = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ans = new System.Windows.Forms.Label();
            this.agc = new System.Windows.Forms.TextBox();
            this.rest = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cpw = new System.Windows.Forms.TextBox();
            this.cpwshow = new System.Windows.Forms.PictureBox();
            this.cpwhide = new System.Windows.Forms.PictureBox();
            this.nwpshow = new System.Windows.Forms.PictureBox();
            this.nwphide = new System.Windows.Forms.PictureBox();
            this.errorPro = new System.Windows.Forms.ErrorProvider(this.components);
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpwshow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpwhide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwpshow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwphide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 48);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(392, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Forget Password";
            // 
            // uid
            // 
            this.uid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uid.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uid.ForeColor = System.Drawing.Color.Red;
            this.uid.Location = new System.Drawing.Point(159, 146);
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(181, 30);
            this.uid.TabIndex = 2;
            this.uid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uid_KeyDown);
            this.uid.Validating += new System.ComponentModel.CancelEventHandler(this.uid_Validating);
            // 
            // nwp
            // 
            this.nwp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nwp.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nwp.ForeColor = System.Drawing.Color.Red;
            this.nwp.Location = new System.Drawing.Point(159, 201);
            this.nwp.Name = "nwp";
            this.nwp.PasswordChar = '*';
            this.nwp.Size = new System.Drawing.Size(181, 30);
            this.nwp.TabIndex = 4;
            this.nwp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nwp_KeyDown);
            this.nwp.Validating += new System.ComponentModel.CancelEventHandler(this.nwp_Validating);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_Project.Properties.Resources.newpassword;
            this.pictureBox2.Location = new System.Drawing.Point(100, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(100, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ans
            // 
            this.ans.AutoSize = true;
            this.ans.Font = new System.Drawing.Font("Buxton Sketch", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans.ForeColor = System.Drawing.Color.Red;
            this.ans.Location = new System.Drawing.Point(160, 301);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(84, 36);
            this.ans.TabIndex = 6;
            this.ans.Text = "label3";
            // 
            // agc
            // 
            this.agc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.agc.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agc.ForeColor = System.Drawing.Color.Red;
            this.agc.Location = new System.Drawing.Point(159, 358);
            this.agc.Name = "agc";
            this.agc.Size = new System.Drawing.Size(181, 30);
            this.agc.TabIndex = 7;
            this.agc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.agc_KeyDown);
            this.agc.Validating += new System.ComponentModel.CancelEventHandler(this.agc_Validating);
            // 
            // rest
            // 
            this.rest.BackColor = System.Drawing.Color.Red;
            this.rest.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rest.ForeColor = System.Drawing.Color.White;
            this.rest.Location = new System.Drawing.Point(180, 412);
            this.rest.Name = "rest";
            this.rest.Size = new System.Drawing.Size(129, 28);
            this.rest.TabIndex = 8;
            this.rest.Text = "Rest Password";
            this.rest.UseVisualStyleBackColor = false;
            this.rest.Click += new System.EventHandler(this.rest_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Final_Project.Properties.Resources.Confirm;
            this.pictureBox3.Location = new System.Drawing.Point(100, 254);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // cpw
            // 
            this.cpw.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cpw.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpw.ForeColor = System.Drawing.Color.Red;
            this.cpw.Location = new System.Drawing.Point(159, 256);
            this.cpw.Name = "cpw";
            this.cpw.PasswordChar = '*';
            this.cpw.Size = new System.Drawing.Size(181, 30);
            this.cpw.TabIndex = 9;
            this.cpw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cpw_KeyDown);
            this.cpw.Validating += new System.ComponentModel.CancelEventHandler(this.cpw_Validating);
            // 
            // cpwshow
            // 
            this.cpwshow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cpwshow.Image = global::Final_Project.Properties.Resources.passop;
            this.cpwshow.Location = new System.Drawing.Point(315, 261);
            this.cpwshow.Name = "cpwshow";
            this.cpwshow.Size = new System.Drawing.Size(20, 20);
            this.cpwshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cpwshow.TabIndex = 12;
            this.cpwshow.TabStop = false;
            this.cpwshow.Click += new System.EventHandler(this.show_Click);
            // 
            // cpwhide
            // 
            this.cpwhide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cpwhide.Image = global::Final_Project.Properties.Resources.passclo;
            this.cpwhide.Location = new System.Drawing.Point(315, 261);
            this.cpwhide.Name = "cpwhide";
            this.cpwhide.Size = new System.Drawing.Size(20, 20);
            this.cpwhide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cpwhide.TabIndex = 11;
            this.cpwhide.TabStop = false;
            this.cpwhide.Click += new System.EventHandler(this.cpwhide_Click);
            // 
            // nwpshow
            // 
            this.nwpshow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nwpshow.Image = global::Final_Project.Properties.Resources.passop;
            this.nwpshow.Location = new System.Drawing.Point(315, 206);
            this.nwpshow.Name = "nwpshow";
            this.nwpshow.Size = new System.Drawing.Size(20, 20);
            this.nwpshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.nwpshow.TabIndex = 14;
            this.nwpshow.TabStop = false;
            this.nwpshow.Click += new System.EventHandler(this.nwpshow_Click);
            // 
            // nwphide
            // 
            this.nwphide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nwphide.Image = global::Final_Project.Properties.Resources.passclo;
            this.nwphide.Location = new System.Drawing.Point(315, 206);
            this.nwphide.Name = "nwphide";
            this.nwphide.Size = new System.Drawing.Size(20, 20);
            this.nwphide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.nwphide.TabIndex = 13;
            this.nwphide.TabStop = false;
            this.nwphide.Click += new System.EventHandler(this.nwphide_Click);
            // 
            // errorPro
            // 
            this.errorPro.ContainerControl = this;
            // 
            // notify
            // 
            this.notify.Text = "notifyIcon1";
            this.notify.Visible = true;
            // 
            // froget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 555);
            this.Controls.Add(this.nwpshow);
            this.Controls.Add(this.nwphide);
            this.Controls.Add(this.cpwshow);
            this.Controls.Add(this.cpwhide);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.cpw);
            this.Controls.Add(this.rest);
            this.Controls.Add(this.agc);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.nwp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "froget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forget Password";
            this.Load += new System.EventHandler(this.froget_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpwshow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpwhide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwpshow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwphide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox nwp;
        private System.Windows.Forms.Label ans;
        private System.Windows.Forms.TextBox agc;
        private System.Windows.Forms.Button rest;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox cpw;
        private System.Windows.Forms.PictureBox cpwshow;
        private System.Windows.Forms.PictureBox cpwhide;
        private System.Windows.Forms.PictureBox nwpshow;
        private System.Windows.Forms.PictureBox nwphide;
        private System.Windows.Forms.ErrorProvider errorPro;
        private System.Windows.Forms.NotifyIcon notify;

    }
}