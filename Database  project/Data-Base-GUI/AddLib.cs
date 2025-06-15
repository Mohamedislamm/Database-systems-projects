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
    public partial class AddLib : Form
    {
        public AddLib()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminui adminui = new adminui();
            adminui.Show();
            this.Hide();
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            BranchName_Box.Text = "";
            Address.Text = "";
            Contact_Box.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            string connString = "Server= SKILLZO; Database= Library; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();

                string checkLib = "SELECT COUNT(*) FROM LIBRARY WHERE BRANCH_NAME = @NAME ";
                SqlCommand checkLibcmd = new SqlCommand(checkLib, conn);
                checkLibcmd.Parameters.AddWithValue("@NAME", BranchName_Box.Text.ToLower());
                int existingAuthorCount = (int)checkLibcmd.ExecuteScalar();

                if (existingAuthorCount > 0)
                {
                    // Author already exists, show message
                    MessageBox.Show("Library Branch already exists in the database.");
                }
                else
                {
                    string Insert = "INSERT INTO LIBRARY VALUES " + "(@ADDRESS, @BRANCHNAME, @CONTACT)";
                    SqlCommand command = new SqlCommand(Insert, conn);
                    command.Parameters.AddWithValue("@ADDRESS", Address.Text.ToLower());
                    command.Parameters.AddWithValue("@BRANCHNAME", BranchName_Box.Text.ToLower());
                    command.Parameters.AddWithValue("@CONTACT", Contact_Box.Text.ToLower());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Library Branch added successfully.");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
