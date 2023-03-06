using System.Collections.Generic;
using csharp_product.Entities;

namespace csharp_product; 

class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();

        Console.Write("Enter the number of products: ");
        int number = int.Parse(Console.ReadLine());

        for(int i = 1; i <= number; i++)
        {
            Console.WriteLine($"Product #{i} data: ");
            Console.Write("Common, used or imported (c/u/i)? ");
            char type = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            if(type == 'u')
            {
                Console.Write("Manufacture date (dd/mm/yyyy): ");
                DateTime dateFab = DateTime.Parse(Console.ReadLine());
                list.Add(new UsedProduct(name, price, dateFab));                
            }else if(type == 'i')
            {
                Console.Write("Customs fee: ");
                double customsFee = double.Parse(Console.ReadLine());
                list.Add(new ImportedProduct(name, price, customsFee));
            }else 
            {
                list.Add(new Product(name, price));
            }
        }

        Console.WriteLine();
        Console.WriteLine("PRICE TAGS:");
        foreach (Product p in list)
        {
            Console.WriteLine(p.PriceTag()); 
        }

    }
}