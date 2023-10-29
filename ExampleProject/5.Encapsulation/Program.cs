using System.Data;
using System.Text;

namespace _5.Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Car myCar = new Car();
            myCar.PrintState();

            Car marry = new Car("Marry");

            //marry.setCurrentSpeed(-10);
            //Виклик метода set у властивості
            marry.CurrentSpeed = 50;
            marry.setPetName("Олена");

            marry.PrintState();

            Car peter = new Car("Peter", -75, "Механіка");
            peter.PrintState();

            Car.CountCarIntance(); 


            
            //myCar.petName = "Test";
            //myCar.currentSpeed = 10;
            //for (int i = 0; i < 10; i++)
            //{
            //    myCar.SpeedUp(5);
            //    myCar.PrintState();
            //}
        }
    }
}