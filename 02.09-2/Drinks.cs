using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._09_2
{
    public class Drinks : Product
    {
        public string Volume { get; set; }

        public Drinks(string name, decimal price, string volume)
        {
            Name = name;
            Price = price;
            Volume = volume;
        }

        public override string GetInformation()
        {
            return $"Название: {Name}, Цена: {Price}, Объем: {Volume}";
        }
        protected override decimal GetDiscount()
        {
            return 0.15m;
        }
    }
}
