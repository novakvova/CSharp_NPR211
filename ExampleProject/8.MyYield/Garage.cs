using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MyYield
{
    public class Garage : IEnumerable
    {
        private int[] marks = { 3, 4, 1, 5 };
        public IEnumerator GetEnumerator()
        {
            foreach (var mark in marks)
            {
                yield return mark;
            }
        }
    }
}
