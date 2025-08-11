using System;

namespace BASIC
{
    internal class SingleInh : PersonDetails
    {
        // Use the same name as used in your method: EmployeeID (not EmployeeId)
        public int EmployeeID { get; set; }
        public string Department { get; set; }

        // Default constructor
        public SingleInh() : base() { }

        // Parameterized constructor
        public SingleInh(string name, int age, string address, string phoneNumber,
                         string email, string occupation, int employeeID, string department)
            : base(name, age, address, phoneNumber, email, occupation)
        {
            EmployeeID = employeeID;
            Department = department;
        }

        // Method to display all employee details
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("\n=====Employee Details=====");
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Department: {Department}");
            base.DisplayPersonDetails(); // Displays inherited person details
        }
    }
}