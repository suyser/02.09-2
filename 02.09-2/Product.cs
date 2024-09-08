using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._09_2
{
    public abstract class Product
    {
        public string Name { get; set; }
        public virtual decimal Price { get; set; }

        public abstract string GetInformation();

        public decimal GetDiscountedPrice()
        {
            decimal discount = GetDiscount();
            return Price - (Price * discount);
        }

        protected virtual decimal GetDiscount()
        {
            return 0.1m;
        }
    }
}
