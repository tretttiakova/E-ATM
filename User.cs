using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

class User
{
    public int currentBalance;
    public string userName, password;

    public User (string name, string password)
    {
        userName = name;
        this.password = password;
    }

    public void withdraw(int sum)
    {
        if (retrievability(sum))
        {
            currentBalance -= sum;
            return;
        }
        MessageBox.Show("No enough money", "ERROR");
    }

    public void transfer(int sum, string payee) //?
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