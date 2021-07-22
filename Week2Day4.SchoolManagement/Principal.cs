using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4.SchoolManagement
{
    class Principal : User
    {
        public int CareersYears { get; set; }
        public List<Student> Students { get; set; } // = new List<Student>();


        public Principal(string code, string firstName, string lastName, string password, SubjectEnum subject, List<Student> students, int careerYears)
       : base(code, firstName, lastName, password, true)
        {
            CareersYears = careerYears;
        }

        public Principal()
        {

        }
    }
}
