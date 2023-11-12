using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Imitation
{
    /// <summary>
    /// Абстрактний клас - можна використовувать лише для наслідування, не можна створить об'єкт
    /// </summary>
    public abstract class Person
    {
        private string name;
        private int age;
        public Person()
        {
            
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Ім'я: {name}\t Вік: {age}");
        }

        public override string ToString()
        {
            return $"Ім'я: {name}\t Вік: {age}";
        }

        public override bool Equals(object obj)
        {
            if(obj == null) return false;
            Person p = obj as Person;
            if(p == null) return false;
            if(p.Name != Name) return false;
            if(p.Age != Age) return false;
            return true;
        }

        public override int GetHashCode()
        {
            string str = Name + Age;
            return str.GetHashCode();
        }


    }
}
