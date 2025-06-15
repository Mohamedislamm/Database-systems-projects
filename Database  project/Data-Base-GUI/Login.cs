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

namespace DataBase
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            Username_Box.Text = "";
            Password_Box.Text = "";
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            string connString = "Server= SKILLZO; Database= Library; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string username = Username_Box.Text;
                string password = Password_Box.Text;
                if(Session.Login(username, password))
                {
                    MessageBox.Show("Login Successful");
                    MessageBox.Show("Welcome " + Session.CurrentUser.FirstName + ' ' + Session.CurrentUser.LastName + "!");
                    if(Session.CurrentUser.Role.ToLower() == "admin")
                    {
                        adminui adminForm = new adminui();
                        adminForm.Show();
                    }
                    else
                    {
                        Userui userForm = new Userui();
                        userForm.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username/email or password.");
                }   
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup SignupForm = new Signup();
            SignupForm.Show();
            this.Hide();
        }
    }
}
