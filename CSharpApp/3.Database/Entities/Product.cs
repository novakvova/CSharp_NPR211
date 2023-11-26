using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _3.Database.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CreatedDate { get; set; }
        public decimal Price { get; set; }
        public List<string> Images { get; set; }

        public override string ToString()
        {
            return Id + "\t" +
                        Name +  $"({CategoryName})\t" +
                        Price + "$\t" + Description + "\t" + CreatedDate;
        }
    }
}
