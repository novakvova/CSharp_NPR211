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

        public void setPetName(string petName) => this.petName = petName;
        public string getPetName() => this.petName;

        public void setCurrentSpeed(int currentSpeed) => this.currentSpeed = currentSpeed;
        public int getCurrentSpeed() => this.currentSpeed;


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
            this.currentSpeed = currentSpeed;
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
