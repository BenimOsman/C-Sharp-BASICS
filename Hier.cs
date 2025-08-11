using System;

namespace BASIC
{
    // First derived class from PersonDetails
    internal class StudentDetails : PersonDetails
    {
        public string Course { get; set; }
        public string University { get; set; }

        public StudentDetails() : base() { }

        public StudentDetails(string name, int age, string address, string phoneNumber,
                              string email, string occupation, string course, string university)
            : base(name, age, address, phoneNumber, email, occupation)
        {
            Course = course;
            University = university;
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("\n===== Student Details =====");
            Console.WriteLine($"Course: {Course}");
            Console.WriteLine($"University: {University}");
            base.DisplayPersonDetails();
        }
    }

    // Second derived class from PersonDetails
    internal class CustomerDetails : PersonDetails
    {
        public string CustomerID { get; set; }
        public string MembershipLevel { get; set; }

        public CustomerDetails() : base() { }

        public CustomerDetails(string name, int age, string address, string phoneNumber,
                               string email, string occupation, string customerID, string membershipLevel)
            : base(name, age, address, phoneNumber, email, occupation)
        {
            CustomerID = customerID;
            MembershipLevel = membershipLevel;
        }

        public void DisplayCustomerDetails()
        {
            Console.WriteLine("\n===== Customer Details =====");
            Console.WriteLine($"Customer ID: {CustomerID}");
            Console.WriteLine($"Membership Level: {MembershipLevel}");
            base.DisplayPersonDetails();
        }
    }
}