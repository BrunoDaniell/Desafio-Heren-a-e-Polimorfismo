using System;
using System.Globalization;
using desafiohp.Entitites;
using System.Collections.Generic;

class URI
{
    static void Main(string[] args)
    {

        Console.Write("Enter the number of products: ");
        int n = int.Parse(Console.ReadLine());

        List<Product> list = new List<Product>();

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Product #{i} data:");
            Console.Write("Cammon, used or imported (c/u/i)? ");
            char type = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (type == 'c' )
            {
                list.Add(new Product(name, price));
            }
            else if(type == 'u')
            {
                Console.Write("Manufacture date (DD/MM/YYYYY): ");
                DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                list.Add(new UsedProduct(name, price, manufactureDate));
            }
            else if (type == 'i')
            {
                Console.Write("Customs fee: ");
                double cutomFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new ImportedProduct(name, price, cutomFee));
            }
            

        }

        Console.WriteLine();
        Console.WriteLine("PRICE TAGS:");

        foreach (Product product in list)
        {
            Console.WriteLine(product.PriceTag());
        }

    }

}