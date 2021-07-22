using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4.SchoolManagement
{
    class Student : User
    {
        //elenco materie - voti
        public Dictionary<SubjectEnum, int> Ranks;//= new Dictionary<SubjectEnum, int>();

        public Student(string code, string firstName, string lastName, string password, Dictionary<SubjectEnum, int> ranks)
         : base(code, firstName, lastName, password, false)
        {
            Ranks = ranks;
        }

        public Student()
        {

        }
    }
}
