using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerItem
{
    public class Burger
    {
        public string Name { get; set; }
        public string TypeOfMeat { get; set; }
        public double Price { get; set; }
        public bool Sold { get; set; }

        public string Display { get { return string.Format($"{Name} ({TypeOfMeat}) , ${Price}"); } }

        public Burger()
        {

        }
        public Burger(string name, string typeofmeat, double price)
        {
            Name = name;
            TypeOfMeat = typeofmeat;
            Price = price;
        }

    }
}
