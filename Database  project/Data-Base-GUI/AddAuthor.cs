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
    public partial class AddAuthor : Form
    {
        public AddAuthor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            FirstName_Box.Text = "";
            LastName_Box.Text = "";
            Email_Box.Text = "";
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            string connString = "Server= SKILLZO; Database= Library; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                
                // Check if author exists
                string checkAuthorQuery = "SELECT COUNT(*) FROM AUTHOR WHERE EMAIL = @EMAIL OR FIRSTNAME + ' ' + LASTNAME = @FIRSTNAME + ' ' + @LASTNAME";
                SqlCommand checkAuthorCommand = new SqlCommand(checkAuthorQuery, conn);
                checkAuthorCommand.Parameters.AddWithValue("@EMAIL", Email_Box.Text.ToLower());
                checkAuthorCommand.Parameters.AddWithValue("@FIRSTNAME", FirstName_Box.Text.ToLower());
                checkAuthorCommand.Parameters.AddWithValue("@LASTNAME", LastName_Box.Text.ToLower());
                int existingAuthorCount = (int)checkAuthorCommand.ExecuteScalar();

                if (existingAuthorCount > 0)
                {
                    // Author already exists, show message
                    MessageBox.Show("Author already exists in the database.");
                }
                else
                { 
                    string Insert = "INSERT INTO AUTHOR VALUES " + "(@EMAIL, @FIRSTNAME, @LASTNAME)";
                    SqlCommand command = new SqlCommand(Insert, conn);
                    command.Parameters.AddWithValue("@EMAIL", Email_Box.Text.ToLower());
                    command.Parameters.AddWithValue("@FIRSTNAME", FirstName_Box.Text.ToLower());
                    command.Parameters.AddWithValue("@LASTNAME", LastName_Box.Text.ToLower());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Author added successfully.");
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
