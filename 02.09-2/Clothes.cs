using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._09_2
{
    public class Clothes : Product
    {
        public string Size { get; set; }

        public Clothes(string name, decimal price, string size)
        {
            Name = name;
            Price = price;
            Size = size;
        }

        public override string GetInformation()
        {
            return $"Название: {Name}, Цена: {Price}, Размер: {Size}";
        }

        protected override decimal GetDiscount()
        {
            return 0.25m;
        }
    }
}
