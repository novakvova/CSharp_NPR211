using System.Text;

namespace _11.DeletageEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            //Console.WriteLine("Привіт!");
            Car car = new Car(10,100, "Audi A7");
            //Робимо підписку на подію (буде спрацьовувать, коли в авто якісь проблеми)
            car.RegisterCarEvent(new Car.CarEventHandler(DisplayInfoCar));
            for (int i = 0; i < 6; i++)
            {
                car.Accelarate(20);
            };
        }
        //Виводить інформацію, яка приходит із зовнішнього об'єкта(автомобіль)
        static void DisplayInfoCar(string message)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine(message);
            Console.WriteLine("----------------------");
        }
    }
}
