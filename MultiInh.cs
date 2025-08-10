using System;

namespace BASIC
{
    internal class MultiInh : SingleInh
    {
        public string ProjectName { get; set; }
        public string Role { get; set; }

        public MultiInh() : base() { }

        public MultiInh(string name, int employeeid, int age, string address, string number, string email,
                        string occupation, string department, string projectName, string role)
            : base(name, employeeid, age, address, number, email, occupation, department)
        {
            ProjectName = projectName;
            Role = role;
        }

        public void DisplayCompleteDetails()
        {
            Console.WriteLine("===== Complete Employee Details =====");
            Console.WriteLine($"Project Name: {ProjectName}");
            Console.WriteLine($"Role: {Role}");
            DisplayEmployeeDetails();                                       // From SingleInh
        }
    }
}