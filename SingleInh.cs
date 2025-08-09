using BASIC;
using System;

namespace BASIC
{
    internal class SingleInh : PersonDetails
    {
        public int EmployeeID { get; set; }
        public string? Department { get; set; }

        public SingleInh() : base() { }

        public SingleInh(string name, int employeeid, int age, string address, string number, string email, string occupation, string department)
            : base(name, age, address, number, email, occupation)
        {
            EmployeeID = employeeid;
            Department = department;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine(GetPersonDetails());
        }
    }
}