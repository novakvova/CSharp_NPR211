using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _5.Encapsulation
{
    /// <summary>
    /// internal - клас доступний в межах даної збірки (простору імен)
    /// public - клас доступний у бутьякому проекті на зовні
    /// </summary>
    public class Car
    {
        /// <summary>
        /// Назва авто
        /// </summary>
        private string petName;
        /// <summary>
        /// Поточна швидкість
        /// </summary>
        private int currentSpeed;

        //Рефакторинг коду (у класі є змінна приватна, яка зберігає значення для моделі)
        //Авто властивість - повертає і ініціалізує значення даної приватної змінної
        public string Model { get; set; }

        public void setPetName(string petName) => this.petName = petName;
        public string getPetName() => this.petName;

        //public void setCurrentSpeed(int currentSpeed)
        //{
        //    if(currentSpeed<0)
        //    {
        //        var colorDefault = Console.ForegroundColor;
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("----Значення швидкості не можу бути мешним 0----");
        //        Console.ForegroundColor = colorDefault;
        //        return;
        //    }
        //    this.currentSpeed = currentSpeed;
        //}
        //public int getCurrentSpeed() => this.currentSpeed;

        //Властивісті - set і get (Cвойства - Properties)
        public int CurrentSpeed
        {
            set   //value - спеціальне ключове слове, яке зберігає значення спрва від знаку =
            {
                if (value < 0)
                {
                    var colorDefault = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("----Значення швидкості не можу бути мешним 0----");
                    Console.ForegroundColor = colorDefault;
                    return;
                }
                this.currentSpeed = value;
            }
            get => this.currentSpeed; 
        }


        private static int count = -1;

        /// <summary>
        /// Визивається лише 1 раз для довільної кількості екземплярів
        /// </summary>
        static Car() { count=0; }
        public Car()
        {
            petName = "Chuck";
            currentSpeed = 10;
            count++;
        }

        public Car(string petName)
        {
            this.petName = petName;
            count++;
        }

        public Car(string petName, int currentSpeed) : this(petName)
        {
            //небезпечний спосіб на пряму присвоєння
            //this.currentSpeed = currentSpeed;
            this.CurrentSpeed = currentSpeed; //більш безпечний спосіб, + є перевірка
        }

        public static void CountCarIntance() 
            => Console.WriteLine($"Створено наступна кількість Car об'єктів {count}");

        /// <summary>
        /// Лямба вираз - стрелочна функція
        /// </summary>
        public void PrintState() 
        { 
            Console.WriteLine("{0} швидкість {1} км.", petName, currentSpeed); 
        }

        /// <summary>
        /// Скорочений запис фукнції - метода
        /// </summary>
        /// <param name="delta">збільшення швидкості</param>
        public void SpeedUp(int delta) 
            => currentSpeed += delta;
    }
}
