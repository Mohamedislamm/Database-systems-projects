using System;
using System.Globalization;
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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            string connString = "Server= SKILLZO; Database= Library; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string Insert = "INSERT INTO BOOK VALUES " + "(@ISBN, @QUANTITY, @TITLE, @PUBLISHERID, @AUTHORID, @AUTHOR, @PUBLISHER, @RATING, @PUBLISHDATE)";
                SqlCommand command = new SqlCommand(Insert, conn);

                string Author = "SELECT AUTHORID FROM AUTHOR WHERE FIRSTNAME + ' ' + LASTNAME = @AUTHOR";
                SqlCommand command1 = new SqlCommand(Author, conn);
                command1.Parameters.AddWithValue("@AUTHOR", Author_Box.Text.ToLower());
                object authorResult = command1.ExecuteScalar();
                string AuthorID = authorResult != null ? authorResult.ToString() : null;

                string Publisher = "SELECT PUBLISHERID FROM PUBLISHER WHERE FIRSTNAME + ' ' + LASTNAME = @PUBLISHER";
                SqlCommand command2 = new SqlCommand(Publisher, conn);
                command2.Parameters.AddWithValue("@PUBLISHER", Publisher_Box.Text.ToLower());
                object publisherResult = command2.ExecuteScalar();
                string PublisherID = publisherResult != null ? publisherResult.ToString() : null;

                if (AuthorID != null && PublisherID != null){
                    command.Parameters.AddWithValue("@ISBN", ISBN_Box.Text);
                    command.Parameters.AddWithValue("@QUANTITY", Quantity_Box.Text);
                    command.Parameters.AddWithValue("@TITLE", Title_Box.Text.ToLower());
                    command.Parameters.AddWithValue("@AUTHOR", Author_Box.Text.ToLower());
                    command.Parameters.AddWithValue("@PUBLISHER", Publisher_Box.Text.ToLower());
                    command.Parameters.AddWithValue("@RATING", Rating_Box.Text);
                    command.Parameters.AddWithValue("@PUBLISHDATE", PublishDate_Box.Value);
                    command.Parameters.AddWithValue("@PUBLISHERID", PublisherID);
                    command.Parameters.AddWithValue("@AUTHORID", AuthorID);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Book added successfully.");
                }
                else
                {
                    if(AuthorID == null && PublisherID == null)
                    {
                        MessageBox.Show("Author and Publisher are not found.");
                    }
                    else if(AuthorID == null)
                    {
                        MessageBox.Show("Author is not found.");
                    }
                    else
                    {
                        MessageBox.Show("Publisher is not found.");
                    }   
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            ISBN_Box.Text = "";
            Quantity_Box.Text = "0";
            Title_Box.Text = "";
            Author_Box.Text = "";
            Publisher_Box.Text = "";
            Rating_Box.Text = "0";
            PublishDate_Box.ResetText();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminui admin_form = new adminui();
            admin_form.Show();
            this.Hide();
        }
    }
    
}