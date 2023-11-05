using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Imitation
{
    public class Teacher : Person
    {
        private string _profession;

        public Teacher(string name, int age)
            : base(name, age) 
        {
            
        }

        public Teacher(string name, int age, string profession)
            : this(name, age)
        {
            _profession = profession;
        }

        public string Profession 
        {  
            get { return _profession; } 
            set {  _profession = value; } 
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Професія: {Profession}");
        }
    }
}
