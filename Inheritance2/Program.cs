using System;
using System.Collections.Generic;
using System.Globalization;
using Inheritance2.Entities;

namespace Inheritance2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------");
            Console.Write("Enter the number of Products to fill data: ");
            int numberOfProducts = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------");

            List<Product> products = new List<Product>();

            for (int i = 1; i <= numberOfProducts; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Product #{i} data:");
                Console.Write("\tIs a Common, Used or Imported Product (c/u/i)?: ");
                string productTypeMenu = (Console.ReadLine().ToLower());

                while (true)
                {
                    if (productTypeMenu == "c" || productTypeMenu == "u" || productTypeMenu == "i")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Choice! Try again...");
                        Console.Write("\tIs a Common, Used or Imported Product (c/u/i)?: ");
                        productTypeMenu = (Console.ReadLine().ToLower());
                    }
                }

                Console.Write("\tProduct Name: ");
                string productName = Console.ReadLine();
                Console.Write("\tProduct Price (without $): ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (productTypeMenu == "c")
                {
                    products.Add(new Product(productName, productPrice));

                }
                else if (productTypeMenu == "u")
                {
                    Console.Write("\tProduct Manufactured Date (mm/dd/yyyy): ");
                    DateTime productManufacturedDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture);

                    products.Add(new UsedProduct(productName, productPrice, productManufacturedDate));
                }
                else if (productTypeMenu == "i")
                {
                    Console.Write("\tProduct Customs Fee (without $): ");
                    double productCustomFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(productName, productPrice, productCustomFee));
                }
            }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Resume:");

            foreach (Product product in products)
            {
                Console.WriteLine();
                Console.WriteLine(product.PriceTag());
            }

            Console.WriteLine();
            Console.WriteLine("Thank you! Bye...\n\n");
        }
    }
}
