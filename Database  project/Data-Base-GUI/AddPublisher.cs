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
    public partial class AddPublisher : Form
    {
        public AddPublisher()
        {
            InitializeComponent();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            string connString = "Server= SKILLZO; Database= Library; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();

                // Check if publisher exists
                string checkPublisherQuery = "SELECT COUNT(*) FROM PUBLISHER WHERE EMAIL = @EMAIL OR FIRSTNAME + ' ' + LASTNAME = @FIRSTNAME + ' ' + @LASTNAME";
                SqlCommand checkPublisherCommand = new SqlCommand(checkPublisherQuery, conn);
                checkPublisherCommand.Parameters.AddWithValue("@EMAIL", Email_Box.Text.ToLower());
                checkPublisherCommand.Parameters.AddWithValue("@FIRSTNAME", FirstName_Box.Text.ToLower());
                checkPublisherCommand.Parameters.AddWithValue("@LASTNAME", LastName_Box.Text.ToLower());
                int existingPublisherCount = (int)checkPublisherCommand.ExecuteScalar();

                if (existingPublisherCount > 0)
                {
                    // Publisher already exists, show message
                    MessageBox.Show("Publisher already exists in the database.");
                }
                else
                {
                    string Insert = "INSERT INTO PUBLISHER VALUES " + "(@FIRSTNAME, @LASTNAME, @EMAIL, @ADDRESS)";
                    SqlCommand command = new SqlCommand(Insert, conn);
                    command.Parameters.AddWithValue("@FIRSTNAME", FirstName_Box.Text.ToLower());
                    command.Parameters.AddWithValue("@LASTNAME", LastName_Box.Text.ToLower());
                    command.Parameters.AddWithValue("@EMAIL", Email_Box.Text.ToLower());
                    command.Parameters.AddWithValue("@ADDRESS", Address_Box.Text.ToLower());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Publisher added successfully.");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            FirstName_Box.Text = "";
            LastName_Box.Text = "";
            Email_Box.Text = "";
            Address_Box.Text = "";
        }
    }
}
