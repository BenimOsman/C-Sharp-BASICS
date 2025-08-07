using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASIC
{
    internal class StudentDatabase
    {
        public void DisplayStudentMarks()
        {
            int[] marks = new int[5];
            int total = 0;

            Console.WriteLine("Enter Marks for 5 Subjects:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Subject {i + 1} marks: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                total = total + marks[i];
            }

            double average = (double)total / marks.Length();

            Console.WriteLine("\nSubject Marks:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Subject {i + 1}: {marks[i]}");
            }

            Console.WriteLine($"\nTotal Marks: {total}");
            Console.WriteLine($"Average Marks: {average}");
        }
    }
}