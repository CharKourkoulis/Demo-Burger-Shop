using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerItem
{
    public class Store
    {

        public string Name { get; set; }
        public List<Burger> Burgers { get; set; }

        public Store(string name)
        {
            Name = name;
            Burgers = new List<Burger>();
        }

    }
}
