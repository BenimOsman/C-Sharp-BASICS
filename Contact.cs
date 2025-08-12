using System;
using System.IO;

namespace BASIC
{
    public class Contact
    {
        public Contact() { }

        public Contact(string name, string phone) { }

        public static void AddContact(string filePath)
        {
            try
            {
                Console.Write("Enter Contact Name: ");
                string? name = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                string? phone = Console.ReadLine();

                string entry = $"{name},{phone}";
                File.AppendAllText(filePath, entry + Environment.NewLine);
                Console.WriteLine("Contact added successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error writing to file: " + ex.Message);
            }
        }

        public static void ViewContacts(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("No contacts found.");
                    return;
                }

                string[] contacts = File.ReadAllLines(filePath);
                if (contacts.Length == 0)
                {
                    Console.WriteLine("Contact List is Empty.");
                    return;
                }

                Console.WriteLine("\n=====All Contacts=====");
                foreach (var contact in contacts)
                {
                    string[] parts = contact.Split(',');
                    if (parts.Length == 2)
                        Console.WriteLine($"Name: {parts[0]}, Phone: {parts[1]}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }
        }

        public static void SearchContact(string filePath)
        {
            Console.Write("Enter Name to Search: ");
            string? searchName = Console.ReadLine();

            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("No contacts found.");
                    return;
                }

                string[] contacts = File.ReadAllLines(filePath);
                bool found = false;

                foreach (var contact in contacts)
                {
                    string[] parts = contact.Split(',');
                    if (parts.Length == 2 && parts[0].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Found:\n Name: {parts[0]}, Phone: {parts[1]}");
                        found = true;
                        break;
                    }
                }

                if (!found)
                    Console.WriteLine("Contact not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }
        }

        public static void ClearContacts(string filePath)
        {
            try
            {
                File.WriteAllText(filePath, string.Empty);
                Console.WriteLine("All contacts have been deleted.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error clearing file: " + ex.Message);
            }
        }
    }
}