using System.Collections.Generic;
using System;
using System.IO;
using System.Text;

static class UserDB
{
    static HashSet<User> users = new HashSet<User>();
    public static User cur_user;
    public static User FindUser(string name)
    {
        foreach (var a in users)
            if (a.userName == name)
                return a;
        return null;
    }
    public static void LoadUsers ()
    {
        FileStream file = new FileStream("users.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(file);
        while (!reader.EndOfStream)
        {
            string[] s = reader.ReadLine().Split(new char[] { ' ' });
            User user = new User(s[0], s[1]);
            user.currentBalance = int.Parse(s[2]);
            users.Add(user);
        }
        reader.Close();
        file.Close();
    }

    public static User Registration(string name, string password)
    {
        if (FindUser(name) != null)
            return null;
        User newUser = new User(name, password);
        users.Add(newUser);
        File.AppendAllText("users.txt", name + " " + password + " 0" + "\n");
        return newUser;
    }
}