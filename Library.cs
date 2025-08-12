using System;
using System.IO;

namespace BASIC
{
    internal class Library
    {
        public string LibrarianName { get; set; }
        public int ShelfNumber { get; set; }
        public string Notes { get; set; }

        public Library() { }

        public Library(string librarianName, int shelfNumber, string notes)
        {
            LibrarianName = librarianName;
            ShelfNumber = shelfNumber;
            Notes = notes;
        }

        public void AddShelfInfo(Library library, string filepath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filepath, true))
                {
                    writer.WriteLine($"{library.LibrarianName},{library.ShelfNumber},{library.Notes}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred while writing to the file: " + ex.Message);
            }
        }

        public void ViewShelfInfo(string filepath)
        {
            Console.WriteLine($"Reading shelf information from {filepath}:");
            try
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException fnfEx)
            {
                Console.WriteLine("File not found: " + fnfEx.Message);
            }
            catch (IOException ioEx)
            {
                Console.WriteLine("An error occurred while reading the file: " + ioEx.Message);
            }
        }
    }
}