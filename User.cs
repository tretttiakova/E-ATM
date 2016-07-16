using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_ATM
{
    class User
    {
        public int currentBalance;
        public string userName, password;

        public void retrieve(int sum)
        {
            if (retrievability(sum))
            {
                currentBalance -= sum;
                return;
            }
            MessageBox.Show("No enough money", "ERROR");
        }

        public void remmitance(int sum, string payee) //?
        {
            if (!retrievability(sum))
            MessageBox.Show("No enough money", "ERROR");

        }

        public void deposit(int sum)
        {
            currentBalance += sum;
        }

        bool retrievability(int sum)
        {
            if (sum <= currentBalance)
                return true;
            return false;
        }

    }
}
