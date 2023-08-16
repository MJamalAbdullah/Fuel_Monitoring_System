namespace Final_Project
{
    partial class passchangeform
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cupw = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.nwp = new System.Windows.Forms.TextBox();
            this.cpw = new System.Windows.Forms.TextBox();
            this.cuhide = new System.Windows.Forms.PictureBox();
            this.cushow = new System.Windows.Forms.PictureBox();
            this.nwpshow = new System.Windows.Forms.PictureBox();
            this.nwphide = new System.Windows.Forms.PictureBox();
            this.cpwshow = new System.Windows.Forms.PictureBox();
            this.cpwhide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuhide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cushow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwpshow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwphide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpwshow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpwhide)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project.Properties.Resources.Confirm;
            this.pictureBox1.Location = new System.Drawing.Point(107, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cupw
            // 
            this.cupw.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cupw.Location = new System.Drawing.Point(166, 78);
            this.cupw.Name = "cupw";
            this.cupw.PasswordChar = '*';
            this.cupw.Size = new System.Drawing.Size(178, 30);
            this.cupw.TabIndex = 1;
            this.cupw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cupw_KeyDown);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Red;
            this.next.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.ForeColor = System.Drawing.Color.White;
            this.next.Image = global::Final_Project.Properties.Resources.passwordchange;
            this.next.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.next.Location = new System.Drawing.Point(195, 247);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(120, 48);
            this.next.TabIndex = 2;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Final_Project.Properties.Resources.newpassword;
            this.pictureBox2.Location = new System.Drawing.Point(107, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Final_Project.Properties.Resources._lock;
            this.pictureBox3.Location = new System.Drawing.Point(107, 73);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // nwp
            // 
            this.nwp.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nwp.Location = new System.Drawing.Point(166, 139);
            this.nwp.Name = "nwp";
            this.nwp.PasswordChar = '*';
            this.nwp.Size = new System.Drawing.Size(178, 30);
            this.nwp.TabIndex = 5;
            this.nwp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nwp_KeyDown);
            // 
            // cpw
            // 
            this.cpw.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpw.Location = new System.Drawing.Point(166, 197);
            this.cpw.Name = "cpw";
            this.cpw.PasswordChar = '*';
            this.cpw.Size = new System.Drawing.Size(178, 30);
            this.cpw.TabIndex = 6;
            this.cpw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cpw_KeyDown);
            // 
            // cuhide
            // 
            this.cuhide.Image = global::Final_Project.Properties.Resources.passclo;
            this.cuhide.Location = new System.Drawing.Point(310, 84);
            this.cuhide.Name = "cuhide";
            this.cuhide.Size = new System.Drawing.Size(20, 20);
            this.cuhide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cuhide.TabIndex = 7;
            this.cuhide.TabStop = false;
            this.cuhide.Click += new System.EventHandler(this.cuhide_Click);
            // 
            // cushow
            // 
            this.cushow.Image = global::Final_Project.Properties.Resources.passop;
            this.cushow.Location = new System.Drawing.Point(310, 84);
            this.cushow.Name = "cushow";
            this.cushow.Size = new System.Drawing.Size(20, 20);
            this.cushow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cushow.TabIndex = 8;
            this.cushow.TabStop = false;
            this.cushow.Click += new System.EventHandler(this.cushow_Click);
            // 
            // nwpshow
            // 
            this.nwpshow.Image = global::Final_Project.Properties.Resources.passop;
            this.nwpshow.Location = new System.Drawing.Point(310, 145);
            this.nwpshow.Name = "nwpshow";
            this.nwpshow.Size = new System.Drawing.Size(20, 20);
            this.nwpshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.nwpshow.TabIndex = 10;
            this.nwpshow.TabStop = false;
            this.nwpshow.Click += new System.EventHandler(this.nwpshow_Click);
            // 
            // nwphide
            // 
            this.nwphide.Image = global::Final_Project.Properties.Resources.passclo;
            this.nwphide.Location = new System.Drawing.Point(310, 145);
            this.nwphide.Name = "nwphide";
            this.nwphide.Size = new System.Drawing.Size(20, 20);
            this.nwphide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.nwphide.TabIndex = 9;
            this.nwphide.TabStop = false;
            this.nwphide.Click += new System.EventHandler(this.nwphide_Click);
            // 
            // cpwshow
            // 
            this.cpwshow.Image = global::Final_Project.Properties.Resources.passop;
            this.cpwshow.Location = new System.Drawing.Point(310, 203);
            this.cpwshow.Name = "cpwshow";
            this.cpwshow.Size = new System.Drawing.Size(20, 20);
            this.cpwshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cpwshow.TabIndex = 12;
            this.cpwshow.TabStop = false;
            this.cpwshow.Click += new System.EventHandler(this.cpwshow_Click);
            // 
            // cpwhide
            // 
            this.cpwhide.Image = global::Final_Project.Properties.Resources.passclo;
            this.cpwhide.Location = new System.Drawing.Point(310, 203);
            this.cpwhide.Name = "cpwhide";
            this.cpwhide.Size = new System.Drawing.Size(20, 20);
            this.cpwhide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cpwhide.TabIndex = 11;
            this.cpwhide.TabStop = false;
            this.cpwhide.Click += new System.EventHandler(this.cpwhide_Click);
            // 
            // passchangeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 358);
            this.Controls.Add(this.cpwshow);
            this.Controls.Add(this.cpwhide);
            this.Controls.Add(this.nwpshow);
            this.Controls.Add(this.nwphide);
            this.Controls.Add(this.cushow);
            this.Controls.Add(this.cuhide);
            this.Controls.Add(this.cpw);
            this.Controls.Add(this.nwp);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.next);
            this.Controls.Add(this.cupw);
            this.Controls.Add(this.pictureBox1);
            this.Name = "passchangeform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "passchangeform";
            this.Load += new System.EventHandler(this.passchangeform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuhide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cushow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwpshow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwphide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpwshow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpwhide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox cupw;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox nwp;
        private System.Windows.Forms.TextBox cpw;
        private System.Windows.Forms.PictureBox cuhide;
        private System.Windows.Forms.PictureBox cushow;
        private System.Windows.Forms.PictureBox nwpshow;
        private System.Windows.Forms.PictureBox nwphide;
        private System.Windows.Forms.PictureBox cpwshow;
        private System.Windows.Forms.PictureBox cpwhide;
    }
}