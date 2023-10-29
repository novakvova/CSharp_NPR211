using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3.Database.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string CreatedDate { get; set; }

        public override string ToString()
        {
            return Id + "\t" +
                        Name + " " + Description + "\t" +
                        Image + "\t" + CreatedDate;
        }
    }
}
