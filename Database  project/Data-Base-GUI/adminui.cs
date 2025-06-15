using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class adminui : Form
    {
        public adminui()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update_book_details updateBook_form = new update_book_details();
            updateBook_form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            browse_books browse_form = new browse_books();
            browse_form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            update_user_details updateUser_form = new update_user_details();
            updateUser_form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Borrow Borrow_Form = new Borrow();
            Borrow_Form.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Session.Logout();
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddAuthor Author_Form = new AddAuthor();
            Author_Form.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddPub addPub = new AddPub();
            addPub.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddLib addLib = new AddLib();
            addLib.Show();
            this.Hide();
        }
    }
    
}
