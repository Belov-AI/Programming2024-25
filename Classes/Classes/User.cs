﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class User
    {
        public string Login;

        private int passwordHash;

        public int PasswordHash
        {
            get => passwordHash;

            private set
            {
                passwordHash = value;
            }
        }

        public User(string login, string password)
        {
            Login = login;
            PasswordHash = password.GetHashCode();
        }

        public void ChangePassword(string newPassword, string oldPassword)
        {
            if(oldPassword.GetHashCode() == PasswordHash) 
            {
                PasswordHash = newPassword.GetHashCode();
            }
        }

    }
}
