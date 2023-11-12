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

        public override string ToString()
        {
            string str = base.ToString();
            return $"{str}\nПрофесія: {Profession}";
        }

        public override bool Equals(object obj)
        {
            var isEqual = base.Equals(obj);
            if (!isEqual) return false;
            Teacher t = obj as Teacher;
            if (t == null) return false;
            if (t.Profession != Profession) return false;
            return true;
        }
        public override int GetHashCode()
        {
            string str = Name + Age + Profession;
            return str.GetHashCode();
        }
    }
}
