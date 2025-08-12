using System;
using System.IO;

namespace BASIC
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public Products() { }

        public Products(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        // Method to add a new product, reading input from the console and appending to file using StreamWriter
        public static void AddProduct(string filePath)
        {
            try
            {
                Console.Write("Enter Product ID: ");
                int id = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Enter Product Name: ");
                string? name = Console.ReadLine();

                Console.Write("Enter Product Price: ");
                decimal price = decimal.Parse(Console.ReadLine() ?? "0");

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{id},{name},{price}");
                }

                Console.WriteLine("Product added successfully.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter numeric ID and price correctly.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error writing to file: " + ex.Message);
            }
        }

        // Method to show all products from the file using StreamReader
        public static void ShowProduct(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("No products found.");
                    return;
                }

                using (StreamReader reader = new StreamReader(filePath))
                {
                    Console.WriteLine("\nProduct List:");
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3 &&
                            int.TryParse(parts[0], out int id) &&
                            decimal.TryParse(parts[2], out decimal price))
                        {
                            Console.WriteLine($"ID: {id}, Name: {parts[1]}, Price: {price:C}");
                        }
                        else
                        {
                            Console.WriteLine("Corrupted product entry found.");
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }
        }
    }
}