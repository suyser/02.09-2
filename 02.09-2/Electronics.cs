using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._09_2
{
    public class Electronics : Product
    {
        public string Brand { get; set; }

        public Electronics(string name, decimal price, string brand)
        {
            Name = name;
            Price = price;
            Brand = brand;
        }

        public override string GetInformation()
        {
            return $"Название: {Name}, Цена: {Price}, Бренд: {Brand}";
        }

        protected override decimal GetDiscount()
        {
            return 0.05m;
        }
    }
}
