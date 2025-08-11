using System;

namespace BASIC
{
    internal class MultipleInh : PersonDetails, IEmployee
    {
        public int EmployeeId { get; set; }
        public string? Department { get; set; }
        public string? Designation { get; set; }
        public double Salary { get; set; }

        public MultipleInh() : base() { }

        public MultipleInh(int employeeId, string name, int age, string address,
                           string phoneNumber, string email, string occupation,
                           string department, string designation, double salary)
            : base(name, age, address, phoneNumber, email, occupation)
        {
            EmployeeId = employeeId;
            Department = department;
            Designation = designation;
            Salary = salary;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("\n=====Employee Info=====");
            Console.WriteLine($"Employee ID   : {EmployeeId}");
            Console.WriteLine($"Department    : {Department}");
            Console.WriteLine($"Designation   : {Designation}");
            Console.WriteLine($"Salary        : {Salary:C}");
            base.DisplayPersonDetails(); // Inherited method
        }

        public string GetEmployeeInfo()
        {
            return $"Employee ID: {EmployeeId}, Department: {Department}, Designation: {Designation}, Salary: {Salary:C}\n"
                   + base.GetPersonDetails();
        }
    }
}