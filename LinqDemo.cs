using BASIC;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASIC
{
    internal class LinqDemo
    {
        int[] numbers = { 101, 122, 365, 14, 95, 86, 57, 78, 89, 10 };

        List<Trainee> trainees = new List<Trainee>
        {
            new Trainee("Z", "T001", "Developer"),
            new Trainee("Y", "T002", "Manager"),
            new Trainee("X", "T003", "Engineer")
        };

        ArrayList arrayList = new ArrayList
        {
            101, 122, 365, 14, 95, 86, 57, 78, 89, 10,
            "Jacob", "Maharaja", "Evie\n"
        };

        // LINQ Queries

        public void BasicLinqery()
        {
            var result = numbers.Take(5);


            foreach (var n in result)
            {
                Console.Write(n + "  ");
            }
            Console.WriteLine();
        }

        public void UsingwhereLinq()
        {
            Console.WriteLine("Using WHERE Clause in LINQ:");
            var result = from no in numbers.Take(5)
                         where no > 70
                         select no;

            foreach (var n in result)
            {
                Console.Write(" " + n);
            }
            Console.WriteLine();
        }

        public void UsingOrderByLinq()
        {
            Console.WriteLine("Using ORDER BY Clause in LINQ: ");
            var result = from trainee in trainees
                         orderby trainee.Name ascending
                         select trainee;
            foreach (var t in result)
            {
                Console.WriteLine($"Name: {t.Name}, Id: {t.Id}, Course: {t.Course}");
            }
        }

        public void LinqOfTypeArraylist()
        {

            var names = arrayList.OfType<string>();
            var numbers = arrayList.OfType<int>();

            Console.WriteLine("Names:");
            foreach (var name in names)
            {
                Console.Write(name + "  ");

            }
            Console.WriteLine("\nNumbers:");

            foreach (var no in numbers)
            {
                Console.Write(no + " ");
            }
            Console.WriteLine();
        }

        public void OrderByThenByLinq()
        {
            Console.WriteLine("Using OrderBy and ThenBy in LINQ:");
            /* var result = from trainee in trainees
                          orderby trainee.Name ascending, trainee.Id descending
                          select trainee;*/
            var result = trainees.OrderBy(t => t.Name).ThenByDescending(t => t.Id);
            foreach (var t in result)
            {
                Console.WriteLine($"Name: {t.Name}, Id: {t.Id}, Course: {t.Course}");
            }
        }

        public void GroupByLinq()
        {
            Console.WriteLine("Using GroupBy in LINQ:");
            var groupedTrainees = trainees.GroupBy(t => t.Course);
            foreach (var group in groupedTrainees)
            {
                Console.WriteLine($"Course: {group.Key}");
                foreach (var trainee in group)
                {
                    Console.WriteLine($"  Name: {trainee.Name}, Id: {trainee.Id}");
                }
            }
        }

        public void TakeLinq()
        {
            Console.WriteLine("Using Take in LINQ:");
            var result = numbers.Take(5);
            foreach (var n in result)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            var takeresult = numbers.TakeWhile(n => n > 100);

            Console.WriteLine("\nUsing TakeWhile in LINQ:");
            foreach (var n in takeresult)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}