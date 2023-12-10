using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Events
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }
        //Поломка авто
        private bool carIdDead;

        public Car() { }
        public Car(int currentSpeed, int maxSpeed, string petName)
        {
            CurrentSpeed = currentSpeed;
            MaxSpeed = maxSpeed;
            PetName = petName;
        }

        public delegate void CarEventDelegate(string message);

        //Спрацьовує коли авто зломаний
        public event CarEventDelegate CarEvent;
        //Спроцьовує перед пломкой - за 10 км.
        public event CarEventDelegate CarEventAbout;

        public void Accelerate(int delta)
        {
            if(carIdDead)
            {
                if(CarEvent != null)
                {
                    CarEvent($"Вибач, але авто ви зломали... Завмер на відмітці {CurrentSpeed}");
                }
            }
            else
            {
                CurrentSpeed += delta;
                if(10==MaxSpeed-CurrentSpeed && CarEventAbout!=null)
                {
                    CarEventAbout($"Не газуй більше, бо буде поломка --{CurrentSpeed}--");
                }
                if (CurrentSpeed >= MaxSpeed)
                {
                    carIdDead = true;
                }
                else
                    Console.WriteLine($"Поточна швидкість = {CurrentSpeed}");
            }
        }



    }
}
