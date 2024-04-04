using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Group
    {
        private string _groupNo;
        private int _studentLimit;


        public string GroupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if (GroupNo.Length != 5)
                {
                    _groupNo = value;
                }
                else
                {
                    Console.WriteLine(char.IsUpper(GroupNo[0]) && char.IsUpper(GroupNo[1]) && char.IsDigit(GroupNo[2]) &&
                        char.IsDigit(GroupNo[3]) && char.IsDigit(GroupNo[4]));
                }
            }


        }
        public int StudentLimit
        {
            get { return _studentLimit; }
            set
            {
                if (value > 5 || value < 18)
                    _studentLimit = value;

            }
        }
         public Group(string groupNo, int stdentLimit)
        {
            _groupNo = groupNo;
            _studentLimit = stdentLimit;
        }


        Student[] Students = new Student[] { };

        public bool CheckGroupNo(string groupNo)
        {
            return GroupNo == GroupNo;
        }

        public void AddStudent (Student student)
        {
            if (Students.Length> StudentLimit)
            {
                Array.Resize(ref Students, Students.Length+1);
                Students[Students.Length-1] = student;    
            }
        }


        public Student[] GetStudent(int Id)
        {
            return Students;
        }
        public Student[] GetAllStudents()
        { 
            return Students; 
        }






    }

}
