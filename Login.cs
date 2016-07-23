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
            UserDB.cur_user = UserDB.FindUser(name);
            if (password == UserDB.cur_user.password)
            {
                var form = new LK();
                form.Show();
                form.Location = this.Location;
                form.StartPosition = FormStartPosition.Manual;
                form.FormClosing += delegate { this.Show(); };
                this.Hide();
                nameBox.Text = "";
                passwordBox.Text = "";
            }
            else
            {
                MessageBox.Show("Wrong login or password", "ERROR");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserDB.FindUser(regNameBox.Text) != null)
            {
                MessageBox.Show("User name is taken", "ERROR");
                return;
            }
            UserDB.Registration(regNameBox.Text, regPasswordBox.Text);
            MessageBox.Show("");
            regNameBox.Text = "";
            regPasswordBox.Text = "";
        }
    }
}
