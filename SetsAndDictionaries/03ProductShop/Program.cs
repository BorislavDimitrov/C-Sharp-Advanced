using System;
using System.Collections.Generic;
using System.Linq;

namespace _03ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Revision")
                {
                    break;
                }

                List<string> shopInfo = input.Split(", ").ToList();
                string shopName = shopInfo[0];
                string productName = shopInfo[1];
                double productPrice = double.Parse(shopInfo[2]);

                if (shops.ContainsKey(shopName))
                {
                    shops[shopName].Add(productName , productPrice);
                }
                else
                {
                    Dictionary<string, double> products = new Dictionary<string, double>();
                    products.Add(productName , productPrice);
                    shops.Add(shopName , products);
                }
            }

            shops = shops.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
