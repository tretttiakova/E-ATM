using System.Collections.Generic;
using System;

static class UserDB
{
    static HashSet<User> users = new HashSet<User>();

    public static User FindUser(string name)
    {
        foreach (var a in users)
            if (a.userName == name)
                return a;
        return null;
    }
    
    public static User Registration(string name, string password)
    {
        if (FindUser(name) != null)
            return null;
        User newUser = new User(name, password);
        users.Add(newUser);
        return newUser;
    }
}