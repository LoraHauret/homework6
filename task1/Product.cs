using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Product
    {
        public string Name { get; set; }
        public Money Cost { get; private set;}
        public Product(string name, Money cost ) 
        {
            Name = name;
            Cost = cost;
        }
        public override string ToString() 
        {
            return string.Format($"Название: {Name} Цена: {Cost}");
        }
        public void increaseCost(double n)
        {
            Cost.Plus(n);
        }
        public void decreaseCost(double n)
        {
            Cost.Minus(n);
        }
    }
}
