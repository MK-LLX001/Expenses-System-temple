using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace Expense_Money
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            string username = "temple";
            string password = "1234";
            if (username.Equals(txtuser.Text) && password.Equals(txtpass.Text))
            {
                this.Hide();
                Expense ex = new Expense();

                ex.ShowDialog();
                this.Close();
            }
            else if (username.Equals(txtuser.Text))
            {
                MessageBox.Show("password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (password.Equals(txtpass.Text))
            {
                MessageBox.Show("username is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("username and password are incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult title = MessageBox.Show("Do you want to Exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (title == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}