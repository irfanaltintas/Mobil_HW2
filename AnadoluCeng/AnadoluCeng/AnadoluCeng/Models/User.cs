using System;
using System.Collections.Generic;
using System.Text;

namespace AnadoluCeng.Models
{
    public class User
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }
        public bool Check()
        {
            if (this.UserName.Equals("irfan") && this.Password.Equals("123456"))
                return true;
            else
                return false;
        }
    }
}
