namespace BASIC
{
    internal interface IEmployee
    {
        int EmployeeId { get; set; }
        string? Department { get; set; }
        string? Designation { get; set; }
        double Salary { get; set; }

        void DisplayEmployeeDetails();
        string GetEmployeeInfo();
    }
}