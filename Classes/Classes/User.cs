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

        private string password;

        public int GetPasswordHash() 
        { 
            return password.GetHashCode();
        }
    }
}
