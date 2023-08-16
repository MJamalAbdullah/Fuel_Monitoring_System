using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        // fields  
        private Button currentButton;
        private Random random;
        private int tempindex;
        private Form activeform;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            homebtn.Visible = false;
            dbconnect();

        }

        //methods

        MySqlConnection con;

        void dbconnect()
        {
            try
            {
                con = new MySqlConnection("server=localhost; user=root; pwd=; database=ceypetco");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /*void displaydata()
        {
            string sql = "select * from ceypetco";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }*/

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempindex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
                homebtn.Visible = false;
            }
            tempindex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(Object btsender)
        {
            if (btsender != null)
            {
                if (currentButton != (Button)btsender)
                {
                    DisableButton();
                    Color Color = SelectThemeColor();
                    currentButton = (Button)btsender;
                    currentButton.BackColor = Color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Cambria", 15.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    homebtn.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousbtn in menupannel.Controls)
            {
                if (previousbtn.GetType() == typeof(Button))
                {
                    previousbtn.BackColor = Color.FromArgb(218, 37, 29);
                    previousbtn.ForeColor = Color.White;
                    previousbtn.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }

        private void openchildForm(Form childform, object btnsender)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            ActivateButton(btnsender);
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.viewpannel.Controls.Add(childform);
            this.viewpannel.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void Rest()
        {
            DisableButton();
            currentButton = null;
            homebtn.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (activeform != null)
                activeform.Close();
            Rest();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            notify.Icon = SystemIcons.Application;
            notify.BalloonTipIcon = ToolTipIcon.Info;
            notify.BalloonTipText = "Login Successful";
            notify.ShowBalloonTip(1000);
        }

        private void date_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void salesbtn_Click(object sender, EventArgs e)
        {
            openchildForm(new Forms.salesform(),sender);
        }

        private void purchasebtn_Click(object sender, EventArgs e)
        {
            openchildForm(new Forms.purchaseform(), sender);
        }

        private void bankbtn_Click(object sender, EventArgs e)
        {
            openchildForm(new Forms.Bankform(), sender);
        }

        private void stockbtn_Click(object sender, EventArgs e)
        {
            openchildForm(new Forms.stockform(), sender);
        }

        private void addproductbtn_Click(object sender, EventArgs e)
        {
            openchildForm(new Forms.addproductform(), sender);
        }

        private void empbtn_Click(object sender, EventArgs e)
        {
            openchildForm(new Forms.empadd(), sender);
        }

        private void settingbtn_Click(object sender, EventArgs e)
        {
            openchildForm(new Forms.settingform(), sender);
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            openchildForm(new Forms.searchform(), sender);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Logout?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                notify.Icon = SystemIcons.Application;
                notify.BalloonTipIcon = ToolTipIcon.Info;
                notify.BalloonTipText = "Logout Successful";
                notify.ShowBalloonTip(1000);
                login login = new login();
                this.Hide();
                login.Show();
            }
            else
            {
                this.Show();
            }
           
        }

        

       
        
        
    }
}
