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
        public static LK instance;
        public LK()
        {
            InitializeComponent();
            instance = this;
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
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            var form = new DepositForm();
            form.Show();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
        }

        public void UpdateBalanceLabel ()
        {
            //string balance = Convert.ToString(UserDB.cur_user.currentBalance);
            balanceLabel.Text = UserDB.cur_user.currentBalance.ToString();
        }
    }
}
