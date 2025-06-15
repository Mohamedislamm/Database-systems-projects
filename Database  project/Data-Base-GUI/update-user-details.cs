using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class update_user_details : Form
    {
        public update_user_details()
        {
            InitializeComponent();
            FirstName_Box.Text = Session.CurrentUser.FirstName;
            LastName_Box.Text = Session.CurrentUser.LastName;
            Address_Box.Text = Session.CurrentUser.Address;
            Phone_Box.Text = Session.CurrentUser.Phone;
            Age_Box.Text = Session.CurrentUser.Age.ToString();
            Email_Box.Text = Session.CurrentUser.Email;
            Username_Box.Text = Session.CurrentUser.Username;
            Password_Box.Text = Session.CurrentUser.Password;

            if (Session.CurrentUser.Role == "admin")
                UserType_Box.SelectedIndex = 1;
            else
                UserType_Box.SelectedIndex = 0;

            if (Session.CurrentUser.Gender == "male")
                Gender_Box.SelectedIndex = 0;
            else
                Gender_Box.SelectedIndex = 1;
        }

        private void FirstName_Box_TextChanged(object sender, EventArgs e)
        {


        }

        private void Submit_Button_Click(object sender, EventArgs e)
        {
            string connString = "Server= SKILLZO; Database= LIBRARY; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();

                string sqlQueryUpdate = "UPDATE [USER] SET FIRSTNAME = @FIRSTNAME, LASTNAME = @LASTNAME, GENDER = @GENDER, ADDRESS = @ADDRESS, AGE = @AGE, PASSWORD = @PASSWORD, EMAIL = @EMAIL, USERNAME = @USERNAME, USERTYPE = @USERTYPE WHERE USERID = @ID";
                SqlCommand command = new SqlCommand(sqlQueryUpdate, conn);

                command.Parameters.AddWithValue("@ID", Session.CurrentUser.UserID);
                command.Parameters.AddWithValue("@FIRSTNAME", FirstName_Box.Text.ToLower());
                command.Parameters.AddWithValue("@LASTNAME", LastName_Box.Text.ToLower());
                command.Parameters.AddWithValue("@GENDER", Gender_Box.Text.ToLower());
                command.Parameters.AddWithValue("@ADDRESS", Address_Box.Text.ToLower());
                command.Parameters.AddWithValue("@AGE", Age_Box.Text);
                command.Parameters.AddWithValue("@PASSWORD", Password_Box.Text);
                command.Parameters.AddWithValue("@EMAIL", Email_Box.Text.ToLower());
                command.Parameters.AddWithValue("@USERNAME", Username_Box.Text.ToLower());
                command.Parameters.AddWithValue("@USERTYPE", UserType_Box.Text.ToLower());
                command.ExecuteNonQuery();

                sqlQueryUpdate = "UPDATE USER_PHONE SET PHONENUM = @PHONENUMBER where USERID = @USERID";
                command = new SqlCommand(sqlQueryUpdate, conn);

                command.Parameters.AddWithValue("@USERID", Session.CurrentUser.UserID);
                command.Parameters.AddWithValue("@PHONENUMBER", Phone_Box.Text);
                command.ExecuteNonQuery();

                MessageBox.Show("User details updated successfully!");

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminui adminui = new adminui();
            adminui.Show();
            this.Hide();
        }
    }
}
