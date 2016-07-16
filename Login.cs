using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_ATM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string password = passwordBox.Text;
            User u = UserDB.FindUser(name);
            if (password == u.password)
            {
                var form = new LK();
                form.Show();
                form.Location = this.Location;
                form.StartPosition = FormStartPosition.Manual;
                form.FormClosing += delegate { this.Show(); };
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login or password is wrong", "Error");
            }
        }
    }
}
