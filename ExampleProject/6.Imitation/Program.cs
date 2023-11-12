using System.Collections;
using System.Text;

namespace _6.Imitation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            //Car myCar = new Car(80);
            //myCar.Speed = 50;
            //Console.WriteLine("My car is gois {0} KM", myCar.Speed);
            //Console.WriteLine();

            //MiniVan t5 = new MiniVan();
            //t5.Speed = 100;

            //Console.WriteLine("My car is gois {0} KM", t5.Speed);

            //t5.currSpeed = 25;

            //Person person = new Person("Іван", 24);
            //Console.WriteLine(person);

            //isAndAs();

            //Person ivan = new Student("Іван Петрович", 32, 1);
            Person ivan = new Teacher("Іван Петрович", 32, "Художник");
            var murchuk = new Teacher("Іван Петрович", 32, "Слюсар");
            var man = new Teacher("Іван Петрович", 32, "Архітектор");
            var salo = new Teacher("Іван Петрович", 32, "Музикант");
            if(ivan.Equals(man))
            {
                Console.WriteLine("ivan == man :)");
            }
            else
            {
                Console.WriteLine("ivan != man :)");
            }
            Console.WriteLine("ivan getHashCode {0}", ivan.GetHashCode());
            Console.WriteLine("man getHashCode {0}", man.GetHashCode());
            Console.WriteLine("murchuk getHashCode {0}", murchuk.GetHashCode());
            Console.WriteLine("salo getHashCode {0}", salo.GetHashCode());

            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, ivan);
            hashtable.Add(2, man);
            hashtable.Add(3, salo);
            hashtable.Add(4, murchuk);
            hashtable.Add(5, ivan);

            //foreach(var val in hashtable.Values)
            //{
            //    Console.WriteLine(val);
            //}




        }

        private static void isAndAs()
        {
            int n = 10;
            Object[] list = new object[10];

            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Person p; //= new Person();
                int r = random.Next(0, 2);
                if (r == 0)
                    p = new Student("Марко", 20, 3);
                else
                    p = new Teacher("Котик", 27, "Програміст");

                list[i] = p;
                //Console.WriteLine(p);
                //p.DisplayInfo();
            }
            showListItems(list);
        }

        private static void showListItems(object[] list)
        {
            foreach (var item in list)
            {
                if (item is Student)
                {
                    //Student student = (Student)item;
                    Student student = item as Student;
                    Console.WriteLine("--------------Студент {0}----------------------", student.Course);
                }
                else if(item is Teacher teacher) 
                {
                    Console.WriteLine("--------------Викладач {0}----------------------", teacher.Profession);
                }
                Console.WriteLine(item);
            }
        }
    }
}