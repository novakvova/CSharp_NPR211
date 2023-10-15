using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Operators
{
    public class MyUserInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName} \n-------------------\n" +
                $"{Description}" +
                $"\n-------------------";
        }
    }
}
