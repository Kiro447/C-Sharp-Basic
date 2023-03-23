using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCodeClasses.Models
{
    public class Product
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        //public Product()
        //{

        //}
        public void Buy(double amount)
        {
            if(amount >= Price)
            {
                Console.WriteLine($"You can buy the product: {Name}");
            }
            else
            {
                Console.WriteLine($"You ain't got enough cash t.e you a brokey");
            }

        }

    }
}
