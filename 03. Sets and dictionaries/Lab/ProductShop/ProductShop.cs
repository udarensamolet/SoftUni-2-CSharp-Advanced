using System;
using System.Linq;
using System.Collections.Generic;

namespace ProductShop
{
    class ProductShop
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            while (input[0] != "Revision")
            {
                string shop = input[0];
                string product = input[1];
                double price = Convert.ToDouble(input[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                    shops[shop].Add(product, price);
                }
                else
                {
                    if (!shops[shop].ContainsKey(product))
                    {
                        shops[shop].Add(product, price);
                    }
                    else
                    {
                        shops[shop][product] = price;
                    }
                }

                input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

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
