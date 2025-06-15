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
    public partial class AddPub : Form
    {
        public AddPub()
        {
            InitializeComponent();
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            PubName_Box.Text = "";
            Email_Box.Text = "";
            Address_Box.Text = "";
            PhoneNumber_Box.Text = "";
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            string connString = "Server= SKILLZO; Database= Library; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();

                // Check if author exists
                string checkAuthorQuery = "SELECT COUNT(*) FROM PUBLISHER WHERE EMAIL = @EMAIL ";
                SqlCommand checkAuthorCommand = new SqlCommand(checkAuthorQuery, conn);
                checkAuthorCommand.Parameters.AddWithValue("@EMAIL", Email_Box.Text.ToLower());
                int existingAuthorCount = (int)checkAuthorCommand.ExecuteScalar();

                if (existingAuthorCount > 0)
                {
                    // Author already exists, show message
                    MessageBox.Show("Publisher already exists in the database.");
                }
                else
                {
                    string Insert = "INSERT INTO PUBLISHER VALUES " + "(@NAME, @EMAIL, @ADDRESS)";
                    SqlCommand command = new SqlCommand(Insert, conn);
                    command.Parameters.AddWithValue("@EMAIL", Email_Box.Text.ToLower());
                    command.Parameters.AddWithValue("@NAME", PubName_Box.Text.ToLower());
                    command.Parameters.AddWithValue("@ADDRESS", Address_Box.Text.ToLower());
                    command.ExecuteNonQuery();

                    string query = "SELECT PUBLISHERID FROM PUBLISHER WHERE EMAIL = @EMAIL";
                    SqlCommand command1 = new SqlCommand(query, conn);
                    command1.Parameters.AddWithValue("@EMAIL", Email_Box.Text.ToLower());
                    int PublisherID = (int)command1.ExecuteScalar();

                    string InsertPhone = "INSERT INTO PUBLISHERPHONE VALUES " + "(@PHONE, @PUBLISHERID)";
                    SqlCommand cmnd = new SqlCommand(InsertPhone, conn);
                    cmnd.Parameters.AddWithValue("@PHONE",PhoneNumber_Box.Text);
                    cmnd.Parameters.AddWithValue("@PUBLISHERID", PublisherID);

                    MessageBox.Show("Publisher added successfully.");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminui admin = new adminui();
            admin.Show();
            this.Hide();
        }
    }
}
