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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            dbconnect();
            hide.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void log_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string sql = "select * from users where user_acc='" + uid.Text + "' and passwords='" + pw.Text + "' ";

                MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                Form1 frm = new Form1();
            
            
                if ((dt.Rows.Count) == 0)
                {
                    MessageBox.Show("Sorry wrong username or password", "User alert",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                else
                {
                    this.Hide();
                    frm.Show();
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            froget froget = new froget();
            froget.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {
            uid.Select();
        }

        private void uid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pw.Focus();
            }
        }

        private void pw_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    con.Open();

                    string sql = "select * from users where user_acc='" + uid.Text + "' and passwords='" + pw.Text + "' ";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    Form1 frm = new Form1();


                    if ((dt.Rows.Count) == 0)
                    {
                        MessageBox.Show("Sorry wrong username or password", "User alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        uid.Clear();
                        pw.Clear();
                        uid.Focus();
                        return;
                    }

                    else
                    {
                        this.Hide();
                        frm.Show();
                    }
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (show.Visible == true)
            {
                show.Hide();
                hide.Show();
                pw.PasswordChar = '\0';
            }
        }

        private void hide_Click(object sender, EventArgs e)
        {
            if (hide.Visible == true)
            {
                hide.Hide();
                show.Show();
                pw.PasswordChar = '*';
            }
        }

        private void uid_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(uid.Text))
            {
                e.Cancel = true;
                uid.Focus();
                errorPro.SetError(uid, "Please Enter Your User Id");
            }
            else
            {
                e.Cancel = false;
                errorPro.SetError(uid,null);
            }
        }

        private void pw_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(pw.Text))
            {
                e.Cancel = true;
                pw.Focus();
                errorPro.SetError(pw, "Please Enter Your User Id");
            }
            else
            {
                e.Cancel = false;
                errorPro.SetError(pw, null);
            }
        }

        
    }
}
