using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DeletageEvent
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }
        //Поломка авто
        private bool carIsDead;
        public Car() { }

        public Car(int currentSpeed, int maxSpeed, string petName)
        {
            CurrentSpeed = currentSpeed;
            MaxSpeed = maxSpeed;
            PetName = petName;
        }

        //1. Визначення делегату
        public delegate void CarEventHandler(string message);
        //2. Ствоерння члену класу делегата - об'єкт, який зберігати вказівник на метод
        private CarEventHandler _carHandler;
        //3. Метод для реєстрації делегата
        public void RegisterCarEvent(CarEventHandler methodToCall)
        {
            _carHandler = methodToCall;
        }
        //Метод для роботи класа
        public void Accelarate(int delta)
        {
            if(carIsDead)
            {
                if(_carHandler != null)
                {
                    _carHandler("Вибачте, автомобіль зломаний ...");
                }
            }
            else
            {
                CurrentSpeed += delta;
                if(10==(MaxSpeed-CurrentSpeed) && _carHandler!=null)
                {
                    _carHandler("Увага! Ви майже досягли максимума.");
                }
                if(CurrentSpeed>=MaxSpeed)
                {
                    carIsDead = true;
                    _carHandler("Носоріг! Ви змогли поломати авто. Швидкість "+CurrentSpeed);
                }
                else
                    Console.WriteLine("Поточна швидкість {0}", CurrentSpeed);
            }
        }
    }
}
