using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        bool drag = false;
        Point start_point = new Point(0,0);
        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void PanelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }    
        }

        private void PanelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            exit();
        }
        private void exit()
        {
            if (MessageBox.Show("Do you want to close this application...?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();
            bool t = false;
            try
            {
                string sql = "select firstname,lastname from Staffs";
                SqlCommand s = new SqlCommand(sql, Databaseconnection.Dataconnect);
                SqlDataReader r = s.ExecuteReader();
                while (r.Read())
                {
                    // take from database

                    string username = r[0].ToString();
                    string password = r[1].ToString();


                    if (username.Equals(user) && password.Equals(pass))
                    {
                        this.Hide();
                        t = true;
                    }
                }

                r.Close();
                s.Dispose();

                if (t == false)
                {
                    MessageBox.Show("Your username or password are incorrect");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                //connect database by Window Authentication
                string ip = ".";
                string dbname = "school";
                Databaseconnection.ConnectionDB(ip, dbname);
                txtPassword.UseSystemPasswordChar = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
