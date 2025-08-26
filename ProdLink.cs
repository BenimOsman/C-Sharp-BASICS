using System;
using System.Collections.Generic;
using System.Linq;

namespace BASIC
{
    internal class ProdLinq
    {
        List<Prod> products = new List<Prod>
        {
            new Prod(1, "Laptop", 79999.99, new DateTime(2025, 1, 15)),
            new Prod(2, "Smartphone", 49999.50, new DateTime(2025, 2, 10)),
            new Prod(3, "Tablet", 29999.00, new DateTime(2025, 3, 5)),
            new Prod(4, "Monitor", 15999.75, new DateTime(2025, 4, 20)),
            new Prod(5, "Keyboard", 1999.99, new DateTime(2025, 5, 25)),
            new Prod(6, "Mouse", 999.50, new DateTime(2025, 6, 30)),
            new Prod(7, "Printer", 8999.00, new DateTime(2025, 7, 15)),
            new Prod(8, "Speaker", 3499.99, new DateTime(2025, 8, 1)),
            new Prod(9, "Webcam", 2499.00, new DateTime(2025, 8, 5)),
            new Prod(10, "Router", 3999.00, new DateTime(2025, 8, 10))
        };

        public void DisplayAllProducts()
        {
            Console.WriteLine("All Products:");
            foreach (var p in products)
            {
                Console.WriteLine($"ID: {p.Id}, Name: {p.Name}, Price: {p.Price}, Manufactured: {p.ManFDate:yyyy-MM-dd}");
            }
        }

        // 1st Query: List of Products
        public void ListOfProducts()                                        
        {
            try
            {
                Console.WriteLine("\nList of Products:");

                var result = products.Take(8);                              // Ensures at least 8 items are shown

                foreach (var p in result)
                {
                    Console.WriteLine($"{p.Name}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while listing products: " + ex.Message);
            }
        }

        // 2nd Query: Displaying 5 Products  
        public void BasicLinqery()
        {
            Console.WriteLine("Basic LINQ Query - First 5 Products:");
            try
            {
                var result = products.Take(5);
                foreach (var p in result)
                {
                    Console.WriteLine($"ID: {p.Id}, Name: {p.Name}, Price: {p.Price}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // 3. Displaying Products with Price > 10000
        public void UsingWhereLinq()
        {
            Console.WriteLine("\nUsing WHERE Clause in LINQ - Products with Price > 10000:");
            try
            {
                var result = products.Where(p => p.Price > 10000).Take(5);
                foreach (var p in result)
                {
                    Console.WriteLine($"Name: {p.Name}, Price: {p.Price}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // 4. Displaying Products Ordered by Name
        public void UsingOrderByLinq()
        {
            Console.WriteLine("\nUsing ORDER BY Clause in LINQ - Products Ordered by Name:");
            try
            {
                var result = products.OrderBy(p => p.Name);
                foreach (var p in result)
                {
                    Console.WriteLine($"Name: {p.Name}, Price: {p.Price}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // 5. Displaying Products Grouped by Manufacturing Month
        public void OrderByThenByLinq()
        {
            Console.WriteLine("\nUsing OrderBy and ThenBy in LINQ:");
            try
            {
                var result = products.OrderBy(p => p.Name).ThenByDescending(p => p.Price);
                foreach (var p in result)
                {
                    Console.WriteLine($"Name: {p.Name}, Price: {p.Price}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // 6. Grouping Products by Manufacturing Month
        public void GroupByLinq()
        {
            Console.WriteLine("\nUsing GroupBy in LINQ - Group by Manufacturing Month:");
            try
            {
                var groupedProducts = products.GroupBy(p => p.ManFDate.Month);
                foreach (var group in groupedProducts)
                {
                    Console.WriteLine($"Month: {group.Key}");
                    foreach (var p in group)
                    {
                        Console.WriteLine($"  Name: {p.Name}, Date: {p.ManFDate:yyyy-MM-dd}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // 7. Using Take and TakeWhile in LINQ
        public void TakeLinq()
        {
            Console.WriteLine("\nUsing Take and TakeWhile in LINQ:");
            try
            {
                var result = products.Take(5);
                foreach (var p in result)
                {
                    Console.WriteLine($"Name: {p.Name}, Price: {p.Price}");
                }

                var takeWhileResult = products.TakeWhile(p => p.Price > 10000);
                Console.WriteLine("\nTakeWhile - Products with Price > 10000:");
                foreach (var p in takeWhileResult)
                {
                    Console.WriteLine($"Name: {p.Name}, Price: {p.Price}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // 8. Using FirstOrDefault and Single/SingleOrDefault in LINQ   
        public void LinqFirstOrDefault()
        {
            Console.WriteLine("\nUsing FirstOrDefault in LINQ:");
            try
            {
                var firstExpensiveProduct = products.FirstOrDefault(p => p.Price > 50000);
                if (firstExpensiveProduct != null)
                {
                    Console.WriteLine($"First Product > 50000: {firstExpensiveProduct.Name}, Price: {firstExpensiveProduct.Price}");
                }
                else
                {
                    Console.WriteLine("No product found with price > 50000.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // 9. Using Single and SingleOrDefault in LINQ

        public void SingleOrSingleDefault()
        {
            Console.WriteLine("\nUsing Single and SingleOrDefault in LINQ:");
            try
            {
                var singleProduct = products.Single(p => p.Id == 3);
                Console.WriteLine($"Single Product with ID 3: {singleProduct.Name}, Price: {singleProduct.Price}");

                var singleOrDefaultProduct = products.SingleOrDefault(p => p.Id == 99);
                if (singleOrDefaultProduct != null)
                {
                    Console.WriteLine($"SingleOrDefault Product with ID 99: {singleOrDefaultProduct.Name}, Price: {singleOrDefaultProduct.Price}");
                }
                else
                {
                    Console.WriteLine("No product found with ID 99.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // 10. Using OrderBy in LINQ
        public void OrderByName()
        {
            Console.WriteLine("\nProducts Ordered by Name:");
            var result = products.OrderBy(p => p.Name);
            foreach (var p in result)
            {
                Console.WriteLine($"Name: {p.Name}, Price: {p.Price}");
            }
        }

        // 11. Using GroupBy in LINQ to group products by manufacturing month   
        public void GroupByMonth()
        {
            Console.WriteLine("\nProducts Grouped by Manufacturing Month:");
            var result = products.GroupBy(p => p.ManFDate.Month);
            foreach (var group in result)
            {
                Console.WriteLine($"Month: {group.Key}");
                foreach (var p in group)
                {
                    Console.WriteLine($"  Name: {p.Name}, Date: {p.ManFDate:yyyy-MM-dd}");
                }
            }
        }

        // 12. Using Distinct in LINQ   
        public void FilterByPrice(double minPrice)
        {
            Console.WriteLine($"\nProducts with Price > {minPrice}:");
            var result = products.Where(p => p.Price > minPrice);
            foreach (var p in result)
            {
                Console.WriteLine($"Name: {p.Name}, Price: {p.Price}");
            }
        }
    }
}