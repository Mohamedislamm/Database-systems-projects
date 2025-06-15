using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBase
{
    public partial class update_book_details : Form
    {
        Book selectedBook;
        public update_book_details()
        {
            InitializeComponent();
            ISBN_Box.Text = "Enter ISBN";
            Title_Box.Enabled = false;
            Author_Box.Enabled = false;
            Publisher_Box.Enabled = false;
            Quantity_Box.Enabled = false;
            PublishDate_Box.Enabled = false;
            Rating_Box.Enabled = false;

        }

        private void ISBN_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();
            string connString = "Server= SKILLZO; Database= Library; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();

                // Assume you have text boxes for entering ISBN, publication year, and author
                string isbn = ISBN_Box.Text;

                string sqlQuerySelect = @"SELECT * FROM BOOK WHERE ISBN LIKE '%' + @ISBN + '%'";

                SqlCommand command = new SqlCommand(sqlQuerySelect, conn);

                // Set parameter values
                if (!string.IsNullOrEmpty(isbn))
                {
                    command.Parameters.AddWithValue("@ISBN", isbn);
                }

                // Execute the query
                SqlDataReader reader = command.ExecuteReader(); 

                if (!reader.HasRows)
                {
                    MessageBox.Show("No book found with the given ISBN");
                    return;
                }

                // Display the results
                while (reader.Read())
                {
                    books.Add(new Book
                    {
                        ISBN = (int)reader["ISBN"],
                        Quantity = (int)reader["QUANTITYAVAILABLE"],
                        Title = reader["TITLE"].ToString(),
                        Author = reader["AUTHOR"].ToString(),
                        Publisher = reader["PUBLISHER"].ToString(),
                        Rating = int.Parse(reader["RATING"].ToString()),
                        PublishDate = (DateTime)reader["PUBLISHDATE"]
                    });

                    // Assuming you have a ListBox named listBoxBooks to display the results 

                    Title_Box.Enabled = true;
                    Author_Box.Enabled = true;
                    Publisher_Box.Enabled = true;
                    Quantity_Box.Enabled = true;
                    PublishDate_Box.Enabled = true;
                    Rating_Box.Enabled = true;
                }

                BookList.DataSource = books;
                BookList.DisplayMember = "Title";
                reader.Close();
                conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void BookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BookList.SelectedItem != null)
            {
                selectedBook = (Book)BookList.SelectedItem;
                Title_Box.Text = selectedBook.Title;
                Author_Box.Text = selectedBook.Author;
                Publisher_Box.Text = selectedBook.Publisher;
                Quantity_Box.Text = selectedBook.Quantity.ToString();
                PublishDate_Box.Text = selectedBook.PublishDate.ToString();
                Rating_Box.Text = selectedBook.Rating.ToString();

            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            string connString = "Server= SKILLZO; Database= Library; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();

                string sqlQueryUpdate = "UPDATE BOOK SET TITLE = @TITLE, AUTHOR = @AUTHOR, PUBLISHER = @PUBLISHER, QUANTITYAVAILABLE = @QUANTITY, PUBLISHDATE = @PUBLISHDATE, RATING = @RATING where ISBN = @ISBN";
                SqlCommand command = new SqlCommand(sqlQueryUpdate, conn);

                command.Parameters.AddWithValue("@ISBN", ISBN_Box.Text.ToLower());
                command.Parameters.AddWithValue("@TITLE", Title_Box.Text.ToLower());
                command.Parameters.AddWithValue("@AUTHOR", Author_Box.Text.ToLower());
                command.Parameters.AddWithValue("@PUBLISHER", Publisher_Box.Text.ToLower());
                command.Parameters.AddWithValue("@QUANTITY", int.Parse(Quantity_Box.Text));
                command.Parameters.AddWithValue("@RATING", int.Parse(Rating_Box.Text));
                command.Parameters.AddWithValue("@PUBLISHDATE", PublishDate_Box.Value);

                command.ExecuteNonQuery();
                MessageBox.Show("Book details updated successfully.");
                conn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            ISBN_Box.Text = "Enter ISBN";

            Title_Box.Text = "";
            Author_Box.Text = "";
            Publisher_Box.Text = "";
            Quantity_Box.Text = "";
            PublishDate_Box.Text = "";
            Rating_Box.Text = "";
            BookList.Items.Clear();


            Title_Box.Enabled = false;
            Author_Box.Enabled = false;
            Publisher_Box.Enabled = false;
            Quantity_Box.Enabled = false;
            PublishDate_Box.Enabled = false;
            Rating_Box.Enabled = false;


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminui admin_form = new adminui();
            admin_form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(selectedBook == null)
            {
                MessageBox.Show("please choose a valid book!");
                return;
            }

            string connString = "Server= SKILLZO; Database= Library; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();

                string sqlQuerySelect = "SELECT COUNT(*) FROM BOOK WHERE ISBN = @ISBN";
                SqlCommand cmd = new SqlCommand(sqlQuerySelect, conn);


                cmd.Parameters.AddWithValue("@ISBN", selectedBook.ISBN);
                int existingBorrow = (int)cmd.ExecuteScalar();

                if (existingBorrow <= 0)
                {
                    MessageBox.Show("This Book Doesn't Exist.");
                    return;
                }

                string sqlQueryInsert = "DELETE FROM BOOK WHERE ISBN = @ISBN";
                SqlCommand command = new SqlCommand(sqlQueryInsert, conn);

                command.Parameters.AddWithValue("@ISBN", selectedBook.ISBN.ToString());

                command.ExecuteNonQuery();
                MessageBox.Show("Book Deleted Successfuly !");


                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
