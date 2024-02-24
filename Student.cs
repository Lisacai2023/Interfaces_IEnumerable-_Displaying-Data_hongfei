using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_IEnumerable__Displaying_Data
{
    internal class Student
    {
        string _firstName;

        public Student(string firstName)
        {
            _firstName=firstName;
        }

        public override string ToString()
        {
            return $"{_firstName}";
        }
    }
}
