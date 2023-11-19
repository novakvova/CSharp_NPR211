using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.MyException
{
    public class Student
    {
        private DateTime _dateBirdth;

        public DateTime DateBirdth
        {
            get { return _dateBirdth; }
            set 
            {
                var minDayNow = DateTime.Now.AddYears(-100);
                if (value < minDayNow)
                    throw new StudentDateBirthException("Вік не можу буть старшим 100 років");
                _dateBirdth = value; 
            }
        }
        public string FullName { get; set; }

        public string Specialty { get; set; }

        public Student() { }
        public Student(String fullName, String specialty, DateTime dateBirdth)
        {
            FullName = fullName;
            Specialty = specialty;
            DateBirdth = dateBirdth;
        }

        public override string ToString()
        {
            return $"{this.FullName}\t{this.Specialty}\t{this.DateBirdth}";
        }
    }
}
