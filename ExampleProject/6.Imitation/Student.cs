using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _6.Imitation
{
    public class Student : Person
    {
        private int course;

        public Student(string name, int age) : base(name, age) { }
        //public Student(string name, int age, int course) : base(name, age)
        public Student(string name, int age, int course) : this(name, age)
        {
            Course = course;
        }

        public int Course { get { return course; } set { course = value; } }

        public override string ToString()
        {
            string str = base.ToString();
            return $"{str}\nКурс: {course}";
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Курс: {course}");
        }

        public override bool Equals(object obj)
        {
            var isEqual = base.Equals(obj);
            if (!isEqual) return false;
            Student s = obj as Student;
            if (s == null) return false;
            if (s.Course != Course) return false;
            return true;
        }
    }
}
