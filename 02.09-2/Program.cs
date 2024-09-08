using System;
using System.Collections.Generic;

namespace Shop
{
    public class Program
    {
        static void Main(string[] args)
        {
            _02._09_2.Shop shop = new _02._09_2.Shop();

            shop.AddProduct(new _02._09_2.Toy("Кукла", 1500, "3-6 лет"));
            shop.AddProduct(new _02._09_2.Meat("Говядина", 300, "Говядина"));
            shop.AddProduct(new _02._09_2.Drinks("Cola", 100, "0.5 л"));
            shop.AddProduct(new _02._09_2.Electronics("Телевизор", 50000, "Samsung"));
            shop.AddProduct(new _02._09_2.Clothes("Футболка", 500, "L"));

            shop.PrintProducts();

        }
    }
}
