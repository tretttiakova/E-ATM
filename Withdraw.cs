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
    public partial class Withdraw : Form
    {
        
        public Withdraw()
        {
            InitializeComponent();
        }
        
        private void doneWithdrawButton_Click(object sender, EventArgs e)
        {
            UserDB.cur_user.withdraw((int)withdrawAmount.Value);
            LK.instance.UpdateBalanceLabel();
            this.Close();
        }
    }
}
