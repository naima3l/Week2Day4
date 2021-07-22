using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4.SchoolManagement
{
    class Teacher : User
    {
        public SubjectEnum Subject { get; set; }
        public List<Student> Students { get; set; } // = new List<Student>();


        public Teacher(string code, string firstName, string lastName, string password, SubjectEnum subject, List<Student> students)
       : base(code, firstName, lastName, password, false)
        {
            Subject = subject;
            Students = students;
        }

        public Teacher()
        {

        }
    }

    public enum SubjectEnum
    {
        Literature,
        Math,
        History,
        Chemistry
    }
}
