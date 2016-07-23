using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

static class Program
{
    /// <summary>
    /// Главная точка входа для приложения.
    /// </summary>
    [STAThread]
    static void Main()
    {
        UserDB.Registration("123", "123");
        UserDB.Registration("Zoya", "1");
        User u123 = UserDB.FindUser("123");
        u123.currentBalance = 50;
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new E_ATM.Login());
    }
}