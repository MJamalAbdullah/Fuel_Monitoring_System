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
    public partial class froget : Form
    {
        public froget()
        {
            InitializeComponent();
            autogenerate();
            dbconnect();
            cpwhide.Hide();
            nwphide.Hide();
        }

        //methods

        string xuid;

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

        void clearall()
        {
            uid.Clear();
            nwp.Clear();
            cpw.Clear();
            agc.Clear();

        }

        void autogenerate()
        {
            int len = 8;

            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < len--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }

            ans.Text = res.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login log = new login();
            log.Show();
        }

        private void froget_Load(object sender, EventArgs e)
        {
            uid.Select();
        }

        private void uid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nwp.Focus();
            }
        }

        private void nwp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cpw.Focus();
            }
        }

        private void cpw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                agc.Focus();
            }
        }

        private void rest_Click(object sender, EventArgs e)
        {
            try
            {



                con.Open();
                string sql = "select * from users where User_acc like '%" + uid.Text + "%'";
                //MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader mdr;

                mdr = cmd.ExecuteReader();
                if (!mdr.HasRows)
                {
                    MessageBox.Show("No User Found");
                }
                else
                {
                    while (mdr.Read())
                    {
                        xuid = mdr.GetString("user_acc");
                    }
                }
                mdr.Close();

                if (uid.Text == xuid )
                {
                    if (nwp.Text == cpw.Text)
                    {
                        if (agc.Text == ans.Text)
                        {
                            string sql1 = "update users set passwords='"+cpw.Text+"' where user_acc='"+xuid+"'";
                            MySqlCommand cmd1 = new MySqlCommand(sql1, con);
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Password Change", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            notify.Icon = SystemIcons.Application;
                            notify.BalloonTipIcon = ToolTipIcon.Info;
                            notify.BalloonTipText = "Password Successfully Changed";
                            notify.ShowBalloonTip(1000);
                            this.Hide();
                            login log = new login();
                            log.Show();
                        }
                        else
                        {
                            MessageBox.Show("Re-Enter The Code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            clearall();
                            uid.Focus();
                            autogenerate();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Check Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        clearall();
                        uid.Focus();
                        autogenerate();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong User Id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clearall();
                    uid.Focus();
                    autogenerate();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void agc_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {


                    con.Open();
                    string sql = "select * from users where User_acc like '%" + uid.Text + "%'";
                    //MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader mdr;

                    mdr = cmd.ExecuteReader();
                    if (!mdr.HasRows)
                    {
                        MessageBox.Show("No User Found");
                    }
                    else
                    {
                        while (mdr.Read())
                        {
                            xuid = mdr.GetString("user_acc");
                        }
                    }
                    mdr.Close();

                    if (uid.Text == xuid)
                    {
                        if (nwp.Text == cpw.Text)
                        {
                            if (agc.Text == ans.Text)
                            {
                                string sql1 = "update users set passwords='" + cpw.Text + "' where user_acc='" + xuid + "'";
                                MySqlCommand cmd1 = new MySqlCommand(sql1, con);
                                cmd1.ExecuteNonQuery();
                                MessageBox.Show("Password Change", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                login log = new login();
                                log.Show();
                            }
                            else
                            {
                                MessageBox.Show("Re-Enter The Code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                clearall();
                                uid.Focus();
                                autogenerate();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Check Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            clearall();
                            uid.Focus();
                            autogenerate();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrong User Id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        clearall();
                        uid.Focus();
                        autogenerate();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }

        }

        private void show_Click(object sender, EventArgs e)
        {
            if (cpwshow.Visible == true)
            {
                cpwshow.Hide();
                cpwhide.Show();
                cpw.PasswordChar = '\0';
            }
        }

        private void nwphide_Click(object sender, EventArgs e)
        {
            if (nwphide.Visible == true)
            {
                nwphide.Hide();
                nwpshow.Show();
                nwp.PasswordChar = '*';
            }

        }

        private void nwpshow_Click(object sender, EventArgs e)
        {
            if (nwpshow.Visible == true)
            {
                nwpshow.Hide();
                nwphide.Show();
                nwp.PasswordChar ='\0';
            }

        }

        private void cpwhide_Click(object sender, EventArgs e)
        {
            if (cpw.Visible == true)
            {
                cpwhide.Hide();
                cpwshow.Show();
                cpw.PasswordChar = '*';
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
                errorPro.SetError(uid, null);
            }
        }

        private void nwp_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(nwp.Text))
            {
                e.Cancel = true;
                nwp.Focus();
                errorPro.SetError(nwp, "Please Enter Your User Id");
            }
            else
            {
                e.Cancel = false;
                errorPro.SetError(nwp, null);
            }
        }

        private void cpw_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cpw.Text))
            {
                e.Cancel = true;
                cpw.Focus();
                errorPro.SetError(cpw, "Please Enter Your User Id");
            }
            else
            {
                e.Cancel = false;
                errorPro.SetError(cpw, null);
            }
        }

        private void agc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(agc.Text))
            {
                e.Cancel = true;
                agc.Focus();
                errorPro.SetError(agc, "Please Enter Your User Id");
            }
            else
            {
                e.Cancel = false;
                errorPro.SetError(agc, null);
            }
        }
     
    }
}
