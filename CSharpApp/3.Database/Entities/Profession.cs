using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Database.Entities
{
    /// <summary>
    /// Професія
    /// </summary>
    public class Profession
    {
        private int _id;
        private string _name;

        public int Id 
        { 
            get 
            { 
                return _id; 
            }
            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get
            { 
                return _name; 
            }
            set
            {
                _name = value;
            }
        }

        public override string ToString()
        {
            return $"{Id}\t{Name}";
        }
    }
}
