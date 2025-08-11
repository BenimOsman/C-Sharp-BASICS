using System;

namespace BASIC
{
    internal class MultiInh : SingleInh
    {
        public string Designation { get; set; }
        public double Salary { get; set; }
        public string ProjectName { get; set; }
        public string Role { get; set; }

        public MultiInh() : base() { }

        public MultiInh(string name, int age, string address, string phoneNumber,
                        string email, string occupation, int employeeID, string department,
                        string designation, double salary, string projectName, string role)
            : base(name, age, address, phoneNumber, email, occupation, employeeID, department)
        {
            Designation = designation;
            Salary = salary;
            ProjectName = projectName;
            Role = role;
        }

        public void DisplayCompleteDetails()
        {
            Console.WriteLine("\n===== Complete Employee Details =====");
            Console.WriteLine($"Project Name: {ProjectName}");
            Console.WriteLine($"Role in Project: {Role}");
            Console.WriteLine($"Designation: {Designation}");
            Console.WriteLine($"Salary: {Salary:C}");
            base.DisplayEmployeeDetails();  
        }
    }
}