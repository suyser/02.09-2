using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._09_2
{
    public class Meat : Product
    {
        public string Type { get; set; }

        public Meat(string name, decimal price, string type)
        {
            Name = name;
            Price = price;
            Type = type;
        }

        public override string GetInformation()
        {
            return $"Название: {Name}, Цена: {Price}, Тип: {Type}";
        }
    }
}
