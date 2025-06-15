using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBase
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            string connString = "Server= SKILLZO; Database= Library; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string Insert = "INSERT INTO [USER] VALUES (@FIRSTNAME, @LASTNAME, @GENDER, @ADDRESS, @AGE ,@PASSWORD, @EMAIL, @USERNAME, @USERTYPE)";
                SqlCommand command = new SqlCommand(Insert, conn);

                command.Parameters.AddWithValue("@FIRSTNAME", FirstName_Box.Text.ToLower());
                command.Parameters.AddWithValue("@LASTNAME", LastName_Box.Text.ToLower());
                command.Parameters.AddWithValue("@GENDER", Gender_Box.Text.ToLower());
                command.Parameters.AddWithValue("@ADDRESS", Address_Box.Text);
                command.Parameters.AddWithValue("@USERNAME", Username_Box.Text.ToLower());
                command.Parameters.AddWithValue("@USERTYPE", UserType_Box.Text.ToLower());
                command.Parameters.AddWithValue("@EMAIL", Email_Box.Text.ToLower());
                command.Parameters.AddWithValue("@AGE", Age_Box.Text);
                command.Parameters.AddWithValue("@PASSWORD", Password_Box.Text);
                command.ExecuteNonQuery();

                string query = "SELECT USERID FROM [USER] WHERE EMAIL = @EMAIL";
                SqlCommand command1 = new SqlCommand(query, conn);
                command1.Parameters.AddWithValue("@EMAIL", Email_Box.Text.ToLower());
                int UserID = (int)command1.ExecuteScalar();
                command.CommandText = "INSERT INTO USER_PHONE VALUES " + "(@PHONENUMBER, @USERID)";
                command.Parameters.AddWithValue("@PHONENUMBER", PhoneNumber_Box.Text);
                command.Parameters.AddWithValue("@USERID", UserID);
                command.ExecuteNonQuery();


                MessageBox.Show(" Your account has been made successfully !");
                // Show the new form and hide the current form

                Login LoginForm = new Login();
                LoginForm.Show();
                this.Hide();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            FirstName_Box.Text = "";
            LastName_Box.Text = "";
            Email_Box.Text = "";
            Username_Box.Text = "";
            Password_Box.Text = "";
            Gender_Box.Text = "";
            PhoneNumber_Box.Text = "";
            Address_Box.Text = "";
            Age_Box.Text = "0";
            UserType_Box.Text = "";
        }

        private void Gender_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Label25_Click(object sender, EventArgs e)
        {

        }

        private void Email_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();
            this.Hide();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
    }
}
