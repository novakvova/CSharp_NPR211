using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.MyYield
{
    public class Nurse : ICloneable, IComparable
    {
        public string Name { get; set; }
        public int Experience { get; set; }
        public Kind Kind { get; set; }

        public object Clone()
        {
            return new Nurse
            {
                Name = Name,
                Experience = Experience,
                Kind = Kind
            };
        }

        public int CompareTo(object obj)
        {
            if(obj==null)
                return 1;
            if(obj is Nurse nurse) 
            {
                if (nurse.Name == Name)
                    return nurse.Experience;
                return nurse.Name.CompareTo(Name);
            }
            return 0;
        }

        public override string ToString()
        {
            return $"{Name}\t{Experience}\t{this.Kind}";
        }
    }
}
