using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._09_2
{
    public class Shop
    {
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void PrintProducts()
        {
            Console.WriteLine("Список товаров:");
            foreach (Product product in _products)
            {
                Console.WriteLine($"{product.GetInformation()} (Цена со скидкой: {product.GetDiscountedPrice()})");
            }
        }
    }
}
