using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4.SchoolManagement
{
    public class User
    {
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public User(string code, string firstName, string lastName, string password, bool isAdmin)
        {
            Code = code;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            IsAdmin = isAdmin;
        }

        public User()
        {

        }

        

    }
}
