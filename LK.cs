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
    public partial class LK : Form
    {
        
        public LK()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            var form = new Withdraw();
            form.Show();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            UpdateBalanceLabel();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            var form = new Deposit_form();
            form.Show();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            UpdateBalanceLabel();
        }

        private void UpdateBalanceLabel ()
        {
            //string balance = Convert.ToString(UserDB.cur_user.currentBalance);
            balanceLabel.Text = UserDB.cur_user.currentBalance.ToString();
        }
    }
}
