using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlotvaEdition.Models
{
    internal class User
    {
        public int UserPhone { get; set; }
        public string UserPassword { get; set; }
        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public User(int Userphone, string Userpassword, string role)
        {
            UserPhone = Userphone;
            UserPassword = Userpassword;
            Role = role;
        }
    }
}
