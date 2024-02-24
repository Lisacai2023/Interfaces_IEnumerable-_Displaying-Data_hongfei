using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_IEnumerable__Displaying_Data
{
    internal class SchoolClass : IEnumerable
    {
        List<Student> _classlist;

        public SchoolClass()
        {
            _classlist = new List<Student>();
        }

        internal List<Student> Classlist { get => _classlist; }


        public void AddStudent(Student student)
        {
            _classlist.Add(student);
        }


        public IEnumerator GetEnumerator()
        {
            return new SchoolClassEnumerator( _classlist);
        }

        private class SchoolClassEnumerator : IEnumerator
        {
            int index = -1;
            List<Student> students;

            public SchoolClassEnumerator( List<Student> studentlist)
            {
                students=studentlist;
            }

            public object Current => students[index];

            public bool MoveNext()
            {
                index++;
                if (index >= students.Count)
                {
                    return false;

                }
                else
                {
                    return true;
                }

            }

            public void Reset()
            {
                index = -1;
            }
        }
    }
}
