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
            int a = 12;

            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Person p; //= new Person();
                int r = random.Next(0,2);
                if (r == 0)
                    p = new Student("Марко", 20, 3);
                else
                    p = new Teacher("Котик", 27, "Програміст");
                //Console.WriteLine(p);
                p.DisplayInfo();
            }

        }
    }
}