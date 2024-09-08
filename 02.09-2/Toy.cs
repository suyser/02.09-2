using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._09_2
{
    public class Toy : Product
    {
        public string AgeRange { get; set; }

        public Toy(string name, decimal price, string ageRange)
        {
            Name = name;
            Price = price;
            AgeRange = ageRange;
        }

        public override string GetInformation()
        {
            return $"Название: {Name}, Цена: {Price}, Возрастная группа: {AgeRange}";
        }

        protected override decimal GetDiscount()
        {
            return 0.2m;
        }
    }
}
