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
    public partial class passchangeform : Form
    {
        public passchangeform()
        {
            InitializeComponent();
        }

        private void passchangeform_Load(object sender, EventArgs e)
        {
            cupw.Select();
            hideop();
            dbconnect();
        }

        string curpass;

        // Methods

        void hideop()
        {
            cuhide.Hide();
            nwphide.Hide();
            cpwhide.Hide();
        }

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

        private void cuhide_Click(object sender, EventArgs e)
        {
            if (cuhide.Visible == true)
            {
                cuhide.Hide();
                cushow.Show();
                cupw.PasswordChar = '*';
            }
        }

        private void cushow_Click(object sender, EventArgs e)
        {
            if (cushow.Visible == true)
            {
                cuhide.Show();
                cushow.Hide();
                cupw.PasswordChar = '\0';
            }
         }

        private void nwpshow_Click(object sender, EventArgs e)
        {
            if (nwpshow.Visible == true)
            {
                nwphide.Show();
                nwpshow.Hide();
                nwp.PasswordChar = '\0';
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

        private void cpwhide_Click(object sender, EventArgs e)
        {
            if (cpwhide.Visible == true)
            {
                cpwhide.Hide();
                cpwshow.Show();
                cpw.PasswordChar = '*';
            }
        }

        private void cpwshow_Click(object sender, EventArgs e)
        {
            if (cpwshow.Visible == true)
            {
                cpwhide.Show();
                cpwshow.Hide();
                cpw.PasswordChar = '\0';
            }
        }

        private void cupw_KeyDown(object sender, KeyEventArgs e)
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
            try
            {
                con.Open();
                if (e.KeyCode == Keys.Enter)
                {
                    string sql = "select * from users where paswords like '" + cupw.Text + "'";
                    //MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader mdr;

                    mdr = cmd.ExecuteReader();
                    if (!mdr.HasRows)
                    {
                        MessageBox.Show("Check Current Password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cupw.Clear();
                        nwp.Clear();
                        cpw.Clear();
                        cupw.Focus();
                    }
                    else
                    {
                        if (nwp.Text != cpw.Text)
                        {
                            MessageBox.Show("Check Password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cupw.Clear();
                            nwp.Clear();
                            cpw.Clear();
                            cupw.Focus();
                        }
                        else
                        {
                            String sql1 = "update users set passwords='" + nwp.Text + "' where passwords = '" + cupw.Text + "'";
                            MySqlCommand cmd2 = new MySqlCommand(sql1, con);
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Password Successfully Changed....!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cupw.Clear();
                            nwp.Clear();
                            cpw.Clear();
                        }
                        //while (mdr.Read())
                        //{
                        //    curpass = mdr.GetString("passwors");
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string sql = "select * from users where paswords like '" + cupw.Text + "'";
                //MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader mdr;

                mdr = cmd.ExecuteReader();
                if (!mdr.HasRows)
                {
                    MessageBox.Show("Check Current Password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cupw.Clear();
                    nwp.Clear();
                    cpw.Clear();
                    cupw.Focus();
                }
                else
                {
                    if (nwp.Text != cpw.Text)
                    {
                        MessageBox.Show("Check Password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cupw.Clear();
                        nwp.Clear();
                        cpw.Clear();
                        cupw.Focus();
                    }
                    else
                    {
                        String sql1 = "update users set passwords='" + nwp.Text + "' where passwords = '" + cupw.Text + "'";
                        MySqlCommand cmd2 = new MySqlCommand(sql1, con);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Password Successfully Changed....!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cupw.Clear();
                        nwp.Clear();
                        cpw.Clear();
                    }
                    //while (mdr.Read())
                    //{
                    //    curpass = mdr.GetString("passwors");
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
