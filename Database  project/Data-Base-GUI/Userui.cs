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
    public partial class Userui : Form
    {
        public Userui()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            browse_books browse_form = new browse_books();
            browse_form.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Borrow Borrow_Form= new Borrow();
            Borrow_Form.Show();
            this.Hide();

        }

        private void BorrowButton_Click(object sender, EventArgs e)
        {

        }

        private void Userui_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome " + Session.CurrentUser.FirstName + ' ' + Session.CurrentUser.LastName + "!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Session.Logout();
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
