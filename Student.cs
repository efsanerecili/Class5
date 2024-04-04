using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Student
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public int  Point {  get; set; }
        public Student (int id, string fullname, int point)
        {
            Id = id;
            Fullname = fullname;
            Point = point;

        }
        public void StudentInfo() 
        {
            Console.WriteLine(($"student-Id;{Id},Fullname:{Fullname},Point:{Point}"));
        }
    }
}
