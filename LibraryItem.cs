using System;
using System.IO;

namespace BASIC
{
    public class LibraryItem
    {
        public LibraryItem() { }

        public LibraryItem(string title, string author) { }

        public static void AddItem(string filePath)
        {
            try
            {
                Console.Write("Enter Item Title: ");
                string? title = Console.ReadLine();

                Console.Write("Enter Author Name: ");
                string? author = Console.ReadLine();

                string entry = $"{title},{author}";
                File.AppendAllText(filePath, entry + Environment.NewLine);

                Console.WriteLine("Library item added successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred while writing to the file: " + ex.Message);
            }
        }

        public static void ViewItems(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("No library items found.");
                    return;
                }

                string[] items = File.ReadAllLines(filePath);
                Console.WriteLine("\nLibrary Item List:");

                foreach (string item in items)
                {
                    string[] parts = item.Split(',');
                    if (parts.Length == 2)
                    {
                        Console.WriteLine($"Title: {parts[0]}, Author: {parts[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Corrupted item entry.");
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred while reading the file: " + ex.Message);
            }
        }
    }
}