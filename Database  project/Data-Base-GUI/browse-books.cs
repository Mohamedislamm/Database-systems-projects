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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBase
{
    public partial class browse_books : Form
    {
        public browse_books()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void browse_books_Load(object sender, EventArgs e)
        {
            string connString = "Server= SKILLZO; Database= Library; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();

                string sqlQuerySelect = "SELECT * FROM BOOK WHERE QUANTITYAVAILABLE > 0 order by ISBN;";
                SqlCommand command = new SqlCommand(sqlQuerySelect, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = reader["ISBN"].ToString();
                    item.SubItems.Add(reader["TITLE"].ToString());
                    item.SubItems.Add((string)reader["AUTHOR"]);
                    item.SubItems.Add((string)reader["PUBLISHER"]);
                    item.SubItems.Add(reader["QUANTITYAVAILABLE"].ToString());
                    item.SubItems.Add(reader["RATING"].ToString()); 
                    item.SubItems.Add(((DateTime)reader["PUBLISHDATE"]).Date.Year.ToString()+ '/' + ((DateTime)reader["PUBLISHDATE"]).Date.Month.ToString() + '/' + ((DateTime)reader["PUBLISHDATE"]).Date.Day.ToString() );
                    ListView1.Items.Add(item);
                }

                // Clean up
                reader.Close();

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(Session.CurrentUser.Role == "admin")
            {
                adminui admin_form = new adminui();
                admin_form.Show();
                this.Hide();
            }
            else
            {
                Userui user_form = new Userui();
                user_form.Show();
                this.Hide();
            }   
            this.Hide();
        }
    }
}
