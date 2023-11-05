using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Imitation
{
    public class Car
    {
        public readonly int maxSpeed;
        private int currSpeed;

        public Car(int max) { this.maxSpeed = max; }

        public Car() { maxSpeed = 55; }

        public int Speed
        {
            get { return currSpeed; }
            set
            {
                currSpeed = value;
                if(currSpeed>maxSpeed)
                {
                    currSpeed = maxSpeed;
                }
            }
        }
    }
}
