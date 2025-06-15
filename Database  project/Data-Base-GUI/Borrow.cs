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
    public partial class Borrow : Form
    {
        Book selectedBook;
        DateTime currentDateTime;
        public Borrow()
        {
            InitializeComponent();
            if(Session.CurrentUser.Role.ToLower() == "admin")
            {
                button3.Visible = false;
                button4.Visible = false;
                label5.Visible = false;
                ReturnDate.Visible = false;
            }
            currentDateTime = DateTime.Now;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();
            string connString = "Server= SKILLZO; Database= Library; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string sqlQuerySelect = "SELECT * FROM BOOK WHERE 1=1";
                if (!string.IsNullOrEmpty(ISBN_Box.Text))
                {
                    sqlQuerySelect += " AND ISBN LIKE '%' + @ISBN + '%'";
                }

                if (!string.IsNullOrEmpty(Author_Box.Text))
                {
                    sqlQuerySelect += @" AND AUTHOR LIKE '%' + @AUTHOR + '%'";
                }

                if (!string.IsNullOrEmpty(Publisher_Box.Text))
                {
                    sqlQuerySelect += @" AND PUBLISHER LIKE '%' + @PUBLISHER + '%'";
                }

                DateTime selectedDateTime = PublishDate.Value;

                if (selectedDateTime <= currentDateTime)
                {
                    //sqlQuerySelect += @" AND PUBLISHDATE LIKE '%' + @PUBLISHDATE + '%'"; 
                    sqlQuerySelect += " AND YEAR(PUBLISHDATE) = @PUBLISHDATE";
                }

                SqlCommand command = new SqlCommand(sqlQuerySelect, conn);

                // Set parameter values
                if (!string.IsNullOrEmpty(ISBN_Box.Text))
                {
                    command.Parameters.AddWithValue("@ISBN", ISBN_Box.Text);
                }

                if (!string.IsNullOrEmpty(PublishDate.Value.ToString()))
                {
                    string temp = PublishDate.Value.Year.ToString("D4");
                    command.Parameters.AddWithValue("@PUBLISHDATE", temp);
                }

                if (!string.IsNullOrEmpty(Author_Box.Text))
                {
                    command.Parameters.AddWithValue("@AUTHOR", Author_Box.Text);
                }

                if (!string.IsNullOrEmpty(Publisher_Box.Text))
                {
                    command.Parameters.AddWithValue("@PUBLISHER", Publisher_Box.Text);
                }

                SqlDataReader reader = command.ExecuteReader();

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
                        PublishDate = (DateTime)reader["PUBLISHDATE"],
                        BookID = (int)reader["BOOKID"]
                    });
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

        private void button2_Click(object sender, EventArgs e)
        {
            ISBN_Box.Text = "";
            Author_Box.Text = "";
            Publisher_Box.Text = "";
            PublishDate.ResetText();
            Title_Box.Text = "";
        }

        private void BookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BookList.SelectedItem != null)
            {
                selectedBook = (Book)BookList.SelectedItem;
                ISBN_Box.Text = selectedBook.ISBN.ToString();
                Title_Box.Text = selectedBook.Title;
                Author_Box.Text = selectedBook.Author;
                Publisher_Box.Text = selectedBook.Publisher;
                PublishDate.Value = selectedBook.PublishDate;
            }
        }

        private void Borrow_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connString = "Server= SKILLZO;Database= Library; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();

                string sqlSelect = "SELECT QUANTITYAVAILABLE FROM BOOK WHERE ISBN = @ISBN";
                SqlCommand cmnd = new SqlCommand(sqlSelect, conn);
                cmnd.Parameters.AddWithValue("@ISBN", selectedBook.ISBN);
                SqlDataReader rdr = cmnd.ExecuteReader();
                if (rdr.Read())
                {
                    if ((int)rdr["QUANTITYAVAILABLE"] <= 0)
                    {
                        rdr.Close();
                        MessageBox.Show("There's no more availalbe copies of this book.");
                        return;
                    }
                    rdr.Close();
                }

                string sqlQuerySelect = "SELECT * FROM BORROW WHERE ISBN = @ISBN AND USERID = @USERID";
                SqlCommand command = new SqlCommand(sqlQuerySelect, conn);

                command.Parameters.AddWithValue("@ISBN", selectedBook.ISBN);
                command.Parameters.AddWithValue("@USERID", Session.CurrentUser.UserID);
                SqlDataReader reader = command.ExecuteReader();

                
                if (reader.HasRows)
                {
                    MessageBox.Show("You have already borrowed this book."); 
                    reader.Close();
                }
                else
                {
                    reader.Close();
                    string sqlQueryInsert = "INSERT INTO BORROW VALUES (@ISBN, @BOOKID, @USERID, @RETURNDATE)";
                    SqlCommand InsertComm = new SqlCommand(sqlQueryInsert, conn);

                    InsertComm.Parameters.AddWithValue("@ISBN", selectedBook.ISBN);
                    InsertComm.Parameters.AddWithValue("@USERID", Session.CurrentUser.UserID);
                    InsertComm.Parameters.AddWithValue("@BOOKID", selectedBook.BookID);
                    DateTime selectedDateTime = ReturnDate.Value;

                    if (selectedDateTime > currentDateTime)
                    {
                        InsertComm.Parameters.AddWithValue("@RETURNDATE", ReturnDate.Value);
                        InsertComm.ExecuteNonQuery();
                        MessageBox.Show("Book borrowed successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Return date should be greater than current date.");
                        return;
                    }
                    string sqlQueryUpdate = "Update BOOK set QUANTITYAVAILABLE = QUANTITYAVAILABLE - 1 where ISBN = @ISBNN";
                    SqlCommand cmd = new SqlCommand(sqlQueryUpdate, conn);
                    cmd.Parameters.AddWithValue("@ISBNN", selectedBook.ISBN);
                    cmd.ExecuteNonQuery();
                }

                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connString = "Server= SKILLZO; Database= LIBRARY; Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();

                string sqlQuerySelect = "SELECT COUNT(*) FROM BORROW WHERE USERID = @USERID AND ISBN = @ISBN";
                SqlCommand cmd = new SqlCommand(sqlQuerySelect, conn);

                cmd.Parameters.AddWithValue("@USERID", Session.CurrentUser.UserID);
                cmd.Parameters.AddWithValue("@ISBN", selectedBook.ISBN);
                int existingBorrow = (int)cmd.ExecuteScalar();
                
                if(existingBorrow <= 0)
                {
                    MessageBox.Show("You didn't borrow this book yet.");
                    return;
                }


                string sqlQueryInsert = "DELETE FROM BORROW WHERE USERID = @USERID AND ISBN = @ISBN";
                SqlCommand command = new SqlCommand(sqlQueryInsert, conn);

                command.Parameters.AddWithValue("@USERID", Session.CurrentUser.UserID);
                command.Parameters.AddWithValue("@ISBN", selectedBook.ISBN);

                MessageBox.Show("Book returned successfully.");
                command.ExecuteNonQuery();

                string sqlQueryUpdate = "Update BOOK set QUANTITYAVAILABLE = QUANTITYAVAILABLE + 1 where ISBN = @ISBNN";
                cmd = new SqlCommand(sqlQueryUpdate, conn);
                cmd.Parameters.AddWithValue("@ISBNN", selectedBook.ISBN);
                cmd.ExecuteNonQuery();

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
        }
    }
}
