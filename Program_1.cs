/*

using System;

namespace BASIC
{
    class Program_1
    {
        static double CalculateGrossSalary(int basic, char grade)
        {
            double hra = 0.2 * basic;                                   // HRA is 20% of basic salary
            double da = 0.5 * basic;                                    // DA is 10% of basic salary
            double pf = 0.11 * basic;                                   // PF is 12% of basic salary

            int allow = grade switch
            {
                'A' => 1700,                                           // Allowance for grade A
                'B' => 1500,                                           // Allowance for grade B
                'C' => 1300,                                           // Allowance for grade C
                _ => 1300                                              // Default allowance if grade is not A, B, or C
            };

            return Math.Round(basic + hra + da + allow - pf, 2);       // Calculating gross salary and rounding it to 2 decimal places
        }

        static double CalculateNetSalary(double gross)
        {
            double tax = 0.10 * gross;
            return Math.Round(gross - tax, 2);                          // Calculating net salary by subtracting tax from gross salary and rounding it to 2 decimal places
        }

        static void Main(String[] args)
        {
            Console.WriteLine("Enter the Number of Employees:");
            int count;

            while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nEnter the Details for Employees {i + 1}: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Basic Salary: ");
                int basicSalary;
                while (!int.TryParse(Console.ReadLine(), out basicSalary) || basicSalary <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer for Basic Salary.");
                }

                Console.Write("Grade (A, B, C): ");
                char grade;
                while (!char.TryParse(Console.ReadLine().ToUpper(), out grade) || (grade != 'A' && grade != 'B' && grade != 'C'))
                {
                    Console.WriteLine("Invalid input. Please enter a valid grade (A, B, or C).");
                }
                EmployeeDatabase.AddEmployee(new Employee(name, basicSalary, char.ToUpper(grade)));                                   // Adding employee to the database

                Console.WriteLine("\nEnter the Name of the Employees to Search: ");
                string searchName = Console.ReadLine();

                Employee emp = EmployeeDatabase.GetEmployees()
                    .FirstOrDefault(e => string.Equals(e.Name, searchName, StringComparison.OrdinalIgnoreCase));

                if (emp != null)
                {
                    double grossSalary = CalculateGrossSalary(emp.BasicSalary, emp.Grade);  // Calculating gross salary
                    double netSalary = CalculateNetSalary(grossSalary);                     // Calculating net salary
                    Console.WriteLine($"\nEmployee Name: {emp.Name}");
                    Console.WriteLine($"Basic Salary: {emp.BasicSalary}");
                    Console.WriteLine($"Grade: {emp.Grade}");
                    Console.WriteLine($"Gross Salary: {grossSalary}");
                    Console.WriteLine($"Net Salary: {netSalary}");
                }
                else
                {
                    Console.WriteLine("Employee not found.");
                }
            }
        }
    }
}

*/