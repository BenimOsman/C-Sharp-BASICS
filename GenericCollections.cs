using System;
using System.Collections.Generic;

namespace BASIC
{
    internal class GenericCollections
    {
        public List<int> numbers = new List<int>();
        public List<string> names = new List<string>();
        public List<PersonDetails> persons = new List<PersonDetails>();

        public void AddNumber(int number)
        {
            numbers.Add(number);
        }

        public void AddName(string name)
        {
            names.Add(name);
        }

        public void AddPerson(PersonDetails person)
        {
            persons.Add(person);
            Console.WriteLine($"\nPerson was added.\n{person.GetPersonDetails()}");
        }

        public void RemoveNumber(int number)
        {
            if (numbers.Contains(number))
            {
                numbers.Remove(number);
                Console.WriteLine($"Number {number} removed from the List.");
            }
            else
            {
                Console.WriteLine($"Number {number} not found in the List.");
            }
        }

        public void RemoveName(string name)
        {
            if (names.Contains(name))
            {
                names.Remove(name);
                Console.WriteLine($"Name {name} removed from the List.");
            }
            else
            {
                Console.WriteLine($"Name {name} not found in the List.");
            }
        }

        // Remove person by name (since Id is not present)
        public void RemovePersonByName(string name)
        {
            var personToRemove = persons.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (personToRemove != null)
            {
                persons.Remove(personToRemove);
                Console.WriteLine($"Person with name \"{name}\" removed from the List.");
            }
            else
            {
                Console.WriteLine($"Person with name \"{name}\" not found.");
            }
        }

        public void DisplayNumbers()
        {
            Console.WriteLine("\nNumbers in the List:");
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        public void DisplayNames()
        {
            Console.WriteLine("\nNames in the List:");
            foreach (var name in names)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
        }

        public void DisplayPersons()
        {
            Console.WriteLine("Persons in the List:");
            foreach (var person in persons)
            {
                Console.WriteLine(person.GetPersonDetails());
            }
        }

        public void ClearNumbers()
        {
            numbers.Clear();
            Console.WriteLine("\nAll Numbers cleared from the List.");
        }

        public void ClearNames()
        {
            names.Clear();
            Console.WriteLine("All Names cleared from the List.");
        }

        public void ClearPersons()
        {
            persons.Clear();
            Console.WriteLine("All persons cleared from the List.");
        }
    }
}