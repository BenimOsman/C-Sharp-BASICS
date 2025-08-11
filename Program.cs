using BASIC;
using System;

// Console.WriteLine("Hello, World!");
// Console.WriteLine("Welcome to C# .NET Progamming Language.");


// MethodDemo();
// LoopsDemo();
// PersonDetails();

/*
static void MethodDemo()
{
    int number = 10;
    string greeting = "Hello, C#";

    Console.WriteLine($"Number: {number} and String: {greeting}");              // Prevoius type of variable incorporation
}
*/

/*
static void LoopsDemo()
{
    Loops loops = new Loops();

    Console.WriteLine("Executing For Loop:");
    loops.ForLoopExample();

    Console.WriteLine("\nExecuting While Loop:");
    loops.WhileLoopExample();

    Console.WriteLine("\nExecuting Do-While Loop:");
    loops.DoWhileLoopExample();
}
*/


/*
static void PersonDetails()
{
    Console.WriteLine("Please Enter Your Name: ");
    string name = Console.ReadLine();
    // Console.WriteLine($"Hello, {name}!");

    Console.WriteLine("Please Enter Your City: ");
    string city = Console.ReadLine();
    Console.WriteLine($"Hello, {name} from {city}!");

    Console.WriteLine("Please Enter Your Age: ");
    // int age = Console.Readline() != NULL ? int.Parse(Console.ReadLine()) : 0;

    int age = Convert.ToInt32(Console.ReadLine());

    // Console.WriteLine("Number: {0NewMethod} and Greeting: {1}.", number, greeting);
    Console.WriteLine($"Hello, {name} from {city}, you are {age} years old!");

}
*/

// TwoDimensionalArrayDemo();
// JaggedMethod();

/*
// 2-Dimensional Array Example
static void TwoDimensionalArrayDemo()
{
    int[,] twoDimensionalArray = new int[3, 3]
    {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
    };

    for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
        {
            Console.Write(twoDimensionalArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Jagged Array
static void JaggedMethod()
{
    int[][] jaggedArray = new int[3][];
    jaggedArray[0] = new int[] { 1, 2, 3 };
    jaggedArray[1] = new int[] { 4, 5, 6, 7 };
    jaggedArray[2] = new int[] { 8, 9 };
    Console.WriteLine("\nJagged Array Example:");
    foreach (var array in jaggedArray)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
*/

// Student Database Example
// StudentDatabase studentDb = new StudentDatabase();
// studentDb.DisplayStudentMarks();

// int result = Calculator();
// Console.WriteLine($"RESULT: {result}");


/*
static int Calculator()
{
    Calci cal = new Calci();                                                        // Integrating the Calci class from BASIC namespace
    Console.WriteLine("Enter First Number: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter Second Number: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter Operation (Add, Subtract, Multiply, Divide): ");

    string operation = Console.ReadLine()?.ToLower();
    int result = 0;
    switch (operation)
    {
        case "add":
            result = cal.Add(firstNumber, secondNumber);
            // Console.WriteLine($"Result of Addition: {result}");
            break;
        case "subtract":
            result = cal.Subtract(firstNumber, secondNumber);
            // Console.WriteLine($"Result of Subtraction: {result}");
            break;
        case "multiply":
            result = cal.Multiply(firstNumber, secondNumber);
            // Console.WriteLine($"Result of Multiplication: {result}");
            break;
        case "divide":
            try
            {
                result = cal.Divide(firstNumber, secondNumber);
                // Console.WriteLine($"Result of Division: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            break;
        default:
            Console.WriteLine("Invalid Operation");
            break;
    }
    return result;
}
*/


//VariableDeclarationdemo();
//PersonDetails();

//iresult = CalculationDemo();
//Console.WriteLine( $"The result is: {CalculationDemo()}");

//LoopsDemo();
//StudentGradingDemo();


/*
 * SIR 
static void VariableDeclarationdemo()
{

    // Variable Declaration
    int number = 10;
    string greeting = "Hello, C#";

    Console.WriteLine($"Number: {number}  and {greeting}");
    // previous type of variable incorporation

    Console.WriteLine("Number :{0}  and {1}", number, greeting);
}
*/
/*
 * SIR
static void PersonDetails()
{
    Console.WriteLine("Please enter your name:");
    string name = Console.ReadLine();
    //Console.WriteLine($"Hello, {name}!");

    Console.WriteLine("Please enter your city:");
    string city = Console.ReadLine();
    //Console.WriteLine($"Hello, {name} from {city}!");

    Console.WriteLine("Please enter your age:");
    //int age = Console.ReadLine() != null ? int.Parse(Console.ReadLine()) : 0;
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Hello, {name} from {city}, you are {age} years old!");
}
*/
/*
 * SIR
static string Calci()
{
    Calculator calculator = new Calculator();
    Console.WriteLine("Enter first number:");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number:");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Choose an operation: +, -, *, /");
    string operation = Console.ReadLine();
    int result = 0;
    switch (operation)
    {
        case "+":
            result = calculator.Add(firstNumber, secondNumber);
            break;
        case "-":
            result = calculator.Subtract(firstNumber, secondNumber);
            break;
        case "*":
            result = calculator.Multiply(firstNumber, secondNumber);
            break;
        case "/":
            try
            {
                result = calculator.Divide(firstNumber, secondNumber);
            }
            catch (DivideByZeroException ex)
            {
                // Console.WriteLine(ex.Message);
                // return ; // Exit the program if division by zero occurs
                return ex.Message;
            }
            break;
        default:
            // Console.WriteLine("Invalid operation.");
            return $"Invalid Operation";  
    }

    string endresult = $"The result of {firstNumber} {operation} {secondNumber} is: {result}";
    return endresult;

    // Console.WriteLine($"The result of {firstNumber} {operation} {secondNumber} is: {result}");
}
*/

/*
 * SIR
static void LoopsDemo()
{
    int[] numbers = { 10, 20, 34, 14, 55 };

    foreach (int number in numbers)
    {
        Console.WriteLine($"Number: {number}");
    }

    int i = numbers.Length - 1;

    while (i >= 0)
    {
        Console.WriteLine($"Number: {numbers[i]}");
        i--;
    }

    int ix = numbers.Length - 1;
    do
    {
        Console.WriteLine(numbers[ix]);
        ix--;
    } while (ix >= 0);


    int sum = 0;

    for (int x = 0; x < numbers.Length; x++)
    {
        sum += numbers[x];
    }
    Console.WriteLine($"The sum of the numbers is: {sum}");
}
*/

/*
 * SIR
static void StudentGradingDemo()
{
    Console.WriteLine("Welcome to the Student Grading System!");
    Console.WriteLine("Please enter the student's name:");
    string? studentName = Console.ReadLine();
    Console.WriteLine("Please enter the marks for 5 subjects (separated by spaces):");
    string[] marksInput = Console.ReadLine().Split(' ');
    int[] subjectMarks = new int[5];
    for (int i = 0; i < marksInput.Length && i < subjectMarks.Length; i++)
    {
        subjectMarks[i] = Convert.ToInt32(marksInput[i]);
    }
    StudentGrading student = new StudentGrading(studentName, subjectMarks);
    student.DisplayStudentDetails();
    int totalMarks = student.CalculatetotalMarks();
    double averageMarks = student.CalculateAverageMarks();
    Console.WriteLine($"Total Marks: {totalMarks}");
    Console.WriteLine($"Average Marks: {averageMarks:F2}"); // F2 formats the average to 2 decimal places

    if (averageMarks >= 90)
    {
        Console.WriteLine("Status: A)");
    }
    else if (averageMarks >= 80)
    {
        Console.WriteLine("Status: B");
    }
    else if (averageMarks >= 70)
    {
        Console.WriteLine("Status: C");
    }
    else if (averageMarks >= 60)
    {
        Console.WriteLine("Status: D");
    }
    else if (averageMarks >= 50)
    {
        Console.WriteLine("Status: E");
    }
    else
    {
        Console.WriteLine("Status: Fail");
    }
}
*/

/*
namespace BASIC
{
    class Program
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

// Console.WriteLine(int.MinValue + " " + int.MaxValue);
// Console.WriteLine(long.MinValue + " " + int.MaxValue);
// Console.WriteLine(float.MinValue + " " + int.MaxValue);
// Console.WriteLine(double.MinValue + " " + int.MaxValue);
// Console.WriteLine(decimal.MinValue + " " + int.MaxValue);
// Console.WriteLine(char.MinValue + " " + char.MaxValue);
// Console.WriteLine(bool.FalseString + " " + bool.TrueString);

// EmployeeDemoProgram();

/*
static void EmployeeDemoProgram()
{
    EmployeeDemo employeeDemo = new EmployeeDemo();
    employeeDemo.RunEmployeeDemo();
}
*/

// ProductDemo();

/*
static void ProductDemo()
{
    Console.Write("How many Products you want to Manage? ");
    int productCount;
    while (!int.TryParse(Console.ReadLine(), out productCount) || productCount <= 0)
    {
        Console.WriteLine("Please Enter a Valid Positive Integer.");
        Console.Write("How many Products do you want to Manage? ");
    }

    List<Product> products = new List<Product>();

    // Input product details
    for (int i = 0; i < productCount; i++)
    {
        Console.WriteLine($"\nEnter Details for Product #{i + 1}:");
        Console.Write("Product Name: ");
        string name = Console.ReadLine();

        double price;
        while (true)
        {
            Console.Write("Product Price: ");
            if (double.TryParse(Console.ReadLine(), out price) && price >= 0)
                break;
            Console.WriteLine("Invalid price. Please enter a non-negative number.");
        }

        int quantity;
        while (true)
        {
            Console.Write("Product Quantity: ");
            if (int.TryParse(Console.ReadLine(), out quantity) && quantity >= 0)
                break;
            Console.WriteLine("Invalid Quantity. Please Enter a Non-Negative Integer.");
        }

        products.Add(new Product(name, price, quantity));
    }

    while (true)
    {
        Console.WriteLine("\n--- Product List ---");
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {products[i].ProductName}");
        }
        Console.WriteLine($"{products.Count + 1}. Exit");

        Console.Write("Select a Product to Perform Operations: ");
        if (!int.TryParse(Console.ReadLine(), out int selected) || selected < 1 || selected > products.Count + 1)
        {
            Console.WriteLine("Invalid Selection. Try again.");
            continue;
        }
        if (selected == products.Count + 1)
        {
            Console.WriteLine("Exiting...");
            break;
        }

        Product product = products[selected - 1];

        while (true)
        {
            Console.WriteLine($"\n--- Operations for {product.ProductName} ---");
            Console.WriteLine("1. Display Product Details");
            Console.WriteLine("2. Calculate Total Price");
            Console.WriteLine("3. Apply Discount");
            Console.WriteLine("4. Check Stock Availability");
            Console.WriteLine("5. Restock Product");
            Console.WriteLine("6. Sell Product");
            Console.WriteLine("7. Update Product Price");
            Console.WriteLine("8. Back to Product List");
            Console.Write("Enter your Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    product.DisplayProductDetails();
                    break;
                case "2":
                    Console.WriteLine($"Total Price: {product.CalculateTotalPrice()}");
                    break;
                case "3":
                    Console.Write("Enter Discount Percentage: ");
                    if (double.TryParse(Console.ReadLine(), out double discount))
                    {
                        Console.WriteLine($"Price after {discount}% Discount: {product.ApplyDiscount(discount)}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input.");
                    }
                    break;
                case "4":
                    Console.WriteLine($"Is the product in stock? {(product.IsInStock() ? "Yes" : "No")}");
                    break;
                case "5":
                    Console.Write("Enter Quantity to Re-stock: ");
                    if (int.TryParse(Console.ReadLine(), out int restockQty))
                    {
                        product.Restock(restockQty);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input.");
                    }
                    break;
                case "6":
                    Console.Write("Enter Quantity to Sell: ");
                    if (int.TryParse(Console.ReadLine(), out int sellQty))
                    {
                        product.Sell(sellQty);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    break;
                case "7":
                    Console.Write("Enter New Price: ");
                    if (double.TryParse(Console.ReadLine(), out double newPrice))
                    {
                        product.UpdatePrice(newPrice);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    break;
                case "8":
                    // Go back to product list
                    goto EndProductMenu;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    EndProductMenu:;
    }
}
*/

// PersonDetailsDemo();

/*
static void PersonDetailsDemo()
{
    // Create and set details directly (no user input)
    PersonDetails person = new PersonDetails();
    person.UpdatePersonDetails(
        name: "John Doe",
        age: 30,
        address: "123 Main Street, Whitefield",
        phoneNumber: "555-1234",
        email: "doe.john@example.com",
        occupation: "Data Scientist"
    );

    Console.WriteLine("=== Person Details ===");
    person.DisplayPersonDetails();
}
*/

// Single Inheritance Example
/*
namespace BASIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleInhDemo(); // Call the method here
        }

        static void SingleInhDemo()
        {
            SingleInh employee = new SingleInh();

            Console.Write("Enter Employee ID: ");
            employee.EmployeeID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            employee.Name = Console.ReadLine();

            Console.Write("Enter Employee Age: ");
            employee.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Address: ");
            employee.Address = Console.ReadLine();

            Console.Write("Enter Employee Phone No.: ");
            employee.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Employee Email: ");
            employee.Email = Console.ReadLine();

            Console.Write("Enter Employee Occupation: ");
            employee.Occupation = Console.ReadLine();

            Console.Write("Enter Employee Department: ");
            employee.Department = Console.ReadLine();

            // Display all the details
            employee.DisplayEmployeeDetails();
        }
    }
}
*/

// Multi-Level Inheritance Example
// MultiLInh();         ---     H.W         i.e. PersonDetails -> SingleInh -> MultiInh
// Base Class -> PersonDetails
// Derived Class 1 -> SingleInh 
// Derived Class 2 -> MultiInh

/*
namespace BASIC
{
    public class Program
    {
        static void Main(string[] args)
        {
            MultiInhDemo();
        }

        static void MultiInhDemo()
        {
            MultiInh employee = new MultiInh();

            Console.WriteLine("=====Enter Complete Employee Details=====");

            Console.Write("Name: ");
            employee.Name = Console.ReadLine();

            Console.Write("Age: ");
            employee.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Address: ");
            employee.Address = Console.ReadLine();

            Console.Write("Phone Number: ");
            employee.PhoneNumber = Console.ReadLine();

            Console.Write("Email: ");
            employee.Email = Console.ReadLine();

            Console.Write("Occupation: ");
            employee.Occupation = Console.ReadLine();

            Console.Write("Employee ID: ");
            employee.EmployeeID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Department: ");
            employee.Department = Console.ReadLine();

            Console.Write("Designation: ");
            employee.Designation = Console.ReadLine();

            Console.Write("Salary: ");
            employee.Salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Project Name: ");
            employee.ProjectName = Console.ReadLine();

            Console.Write("Role in Project: ");
            employee.Role = Console.ReadLine();

            // Display all gathered information
            employee.DisplayCompleteDetails();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
*/

// Reprsenting Hierarchical Inheritance                 i.e. PersonDetails → StudentDetails, CustomerDetails
// StudentDetails → Child Class 1 (inherits from PersonDetails)
// CustomerDetails → Child Class 2 (inherits from PersonDetails)

/*
namespace BASIC
{
    public class Program
    {
        static void Main(string[] args)
        {
            HierInh();
        }

        static void HierInh()
        {
            Console.Write("Choose Type (1 - Student, 2 - Customer): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                StudentDetails student = new StudentDetails();

                Console.Write("Enter Name: ");
                student.Name = Console.ReadLine();

                Console.Write("Enter Age: ");
                student.Age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Address: ");
                student.Address = Console.ReadLine();

                Console.Write("Enter Phone No.: ");
                student.PhoneNumber = Console.ReadLine();

                Console.Write("Enter Email: ");
                student.Email = Console.ReadLine();

                Console.Write("Enter Occupation: ");
                student.Occupation = Console.ReadLine();

                Console.Write("Enter Course: ");
                student.Course = Console.ReadLine();

                Console.Write("Enter University: ");
                student.University = Console.ReadLine();

                student.DisplayStudentDetails();
            }
            else if (choice == 2)
            {
                CustomerDetails customer = new CustomerDetails();

                Console.Write("Enter Name: ");
                customer.Name = Console.ReadLine();

                Console.Write("Enter Age: ");
                customer.Age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Address: ");
                customer.Address = Console.ReadLine();

                Console.Write("Enter Phone No.: ");
                customer.PhoneNumber = Console.ReadLine();

                Console.Write("Enter Email: ");
                customer.Email = Console.ReadLine();

                Console.Write("Enter Occupation: ");
                customer.Occupation = Console.ReadLine();

                Console.Write("Enter Customer ID: ");
                customer.CustomerID = Console.ReadLine();

                Console.Write("Enter Membership Level: ");
                customer.MembershipLevel = Console.ReadLine();

                customer.DisplayCustomerDetails();
            }
            else
            {
                Console.WriteLine("Invalid Choice!");
            }
        }
    }
}
*/

// Multiple Inheritance using Interfaces
// IPerson.cs -> 1st Base Class
// IEmployee.cs -> 2nd Base Class

// Multiple.cs -> Derived Class (Inheriting from IPerson.cs & IEmployee.cs)

/*
namespace BASIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====Enter Employee Personal and Job Details=====");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            Console.Write("Enter Phone No.: ");
            string phone = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Occupation: ");
            string occupation = Console.ReadLine();

            Console.Write("Enter Employee ID: ");
            int employeeId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Department: ");
            string department = Console.ReadLine();

            Console.Write("Enter Designation: ");
            string designation = Console.ReadLine();

            Console.Write("Enter Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            // Create MultipleInh object
            MultipleInh employee = new MultipleInh(employeeId, name, age, address, phone, email, occupation, department, designation, salary);

            // Display employee info
            employee.DisplayEmployeeDetails();

            // Uncomment if string-based representation is also needed
            // Console.WriteLine("\nString Representation:");
            // Console.WriteLine(employee.GetEmployeeInfo());

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
*/

// Generic Collections Example
/*
namespace BASIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericCollectionDemo();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void GenericCollectionDemo()
        {
            GenericCollections genericCollections = new GenericCollections();

            Console.Write("How many Numbers do you want to Add to the List? ");
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter Number {i + 1}: ");
                int number = Convert.ToInt32(Console.ReadLine());
                genericCollections.AddNumber(number);
            }

            // Display all numbers
            genericCollections.DisplayNumbers();

            // Remove a number
            Console.Write("\nEnter a Number to Remove from the List: ");
            int numberToRemove = Convert.ToInt32(Console.ReadLine());
            genericCollections.RemoveNumber(numberToRemove);

            // Display after removal
            genericCollections.DisplayNumbers();

            // Clear list
            genericCollections.ClearNumbers();

            // Display after clearing
            genericCollections.DisplayNumbers();
        }
    }
}
*/

/*
namespace BASIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====GENERIC COLLECTION DEMO=====\n");

            // Correctly calling the method inside Program class
            GenericCollectionDemo();
        }

        public static void GenericCollectionDemo()
        {
            GenericCollections genericCollections = new GenericCollections();

            Console.Write("How many Names do you want to Add to the Generic List? ");
            if (!int.TryParse(Console.ReadLine(), out int count) || count < 1)
            {
                Console.WriteLine("Invalid Input. Please Enter a Positive Integer.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter Name {i + 1}: ");
                string? name = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(name))
                {
                    genericCollections.AddName(name);
                }
                else
                {
                    Console.WriteLine("Invalid Name. Skipped.");
                }
            }

            // Display all names
            genericCollections.DisplayNames();

            // Remove a name
            Console.Write("\nEnter a Name to Remove from the List: ");
            string? nameToRemove = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(nameToRemove))
            {
                genericCollections.RemoveName(nameToRemove);
            }
            else
            {
                Console.WriteLine("Invalid Name Entered. Nothing Removed.");
            }

            // Display updated names
            genericCollections.DisplayNames();

            // Optional: Clear the list
            Console.Write("\nDo you want to Clear all Names? (Y/N): ");
            string? response = Console.ReadLine();
            if (response?.Trim().ToLower() == "y")
            {
                genericCollections.ClearNames();
                genericCollections.DisplayNames();
            }
        }
    }
}
*/

/*
namespace BASIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== GENERIC COLLECTION PERSON DEMO ===\n");

            // Call the person-based generic collection demo
            GenericCollectionDemo();
        }

        public static void GenericCollectionDemo()
        {
            GenericCollections genericCollections = new GenericCollections();

            Console.Write("How many Persons do you want to Add to the Generic List? ");
            if (!int.TryParse(Console.ReadLine(), out int count) || count < 1)
            {
                Console.WriteLine("Invalid Input. Please Enter a Positive Integer.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nEnter Details for Person {i + 1}:");

                Console.Write("Name: ");
                string? name = Console.ReadLine() ?? "";

                Console.Write("Age: ");
                if (!int.TryParse(Console.ReadLine(), out int age))
                {
                    Console.WriteLine("Invalid Age. Setting age to 0.");
                    age = 0;
                }

                Console.Write("Address: ");
                string? address = Console.ReadLine() ?? "";

                Console.Write("Phone Number: ");
                string? phoneNumber = Console.ReadLine() ?? "";

                Console.Write("Email: ");
                string? email = Console.ReadLine() ?? "";

                Console.Write("Occupation: ");
                string? occupation = Console.ReadLine() ?? "";

                // Create PersonDetails object using the constructor from your class
                PersonDetails person = new PersonDetails(name, age, address, phoneNumber, email, occupation);

                // Add to collection
                genericCollections.AddPerson(person);
            }

            // Display persons
            genericCollections.DisplayPersons();

            // Remove a person by Name (ID not available)
            Console.Write("\nEnter the Name of the Person you want to Remove: ");
            string? nameToRemove = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(nameToRemove))
            {
                genericCollections.RemovePersonByName(nameToRemove);
            }
            else
            {
                Console.WriteLine("Invalid Name. No person removed.");
            }

            // Display updated list
            genericCollections.DisplayPersons();

            // Optional: Clear the person list
            Console.Write("\nDo you want to Clear all Persons? (Y/N): ");
            string? confirm = Console.ReadLine();
            if (confirm?.Trim().ToLower() == "y")
            {
                genericCollections.ClearPersons();
                genericCollections.DisplayPersons();
            }
        }
    }
}
*/

// Generic Class Example
// Shape<String> shape = new Shape<String>();
// shape.ShapeName = "Circle"; 
// Console.WriteLine($"Shape Name: {shape.ShapeName}");

/*
namespace BASIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Rectangle Length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Rectangle Breadth: ");
            double breadth = Convert.ToDouble(Console.ReadLine());

            // Create Rectangle object
            Rectangle rect = new Rectangle(length, breadth);

            // Pass Rectangle object to the generic Shape<T> class
            Shape<Rectangle> shape = new Shape<Rectangle>(rect);

            // Output the rectangle info using Shape Class
            Console.WriteLine($"\nShape Info: {shape.ShapeName}");
            Console.WriteLine($"Area: {shape.ShapeName.GetArea()}");
            Console.WriteLine($"Perimeter: {shape.ShapeName.GetPerimeter()}");
        }
    }
}
*/

/*
Console.WriteLine("Delegates Example!!!");

CalcDelegate calcDelegate;
DelegatesDemo delegatesDemo = new DelegatesDemo();

calcDelegate = delegatesDemo.Sum; // Assigning the Sum method to the delegate
calcDelegate(10, 20); // Invoking the delegate with parameters  
calcDelegate += delegatesDemo.Multiply; // Adding the Multiply method to the delegate
// Invoking the delegate
calcDelegate(5, 10); // This will call both Sum and Multiply methods

// delegatesDemo.Sum(10, 20);
//delegatesDemo.Multiply(1, 3);

// DelegatesDemo delegatesDemo = new DelegatesDemo();
delegatesDemo.Subscribe(message => Console.WriteLine($"Received Message: {message}"));
delegatesDemo.TriggerEvent("This is a test message after subsribing");
delegatesDemo.Unsubscribe(message => Console.WriteLine($"Received Message: {message}"));
*/

// HW - Work on the Collections
// Work on the Generic Collections i.e. Dictionary, Stack, Queue, ArrayList

// 1. Generic Dictionary
// 2. Generic Stack
// 3. Generic Queue

/*
namespace BASIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====GENERIC COLLECTION DEMO=====");

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nSelect Option:");
                Console.WriteLine("1. Generic Dictionary");
                Console.WriteLine("2. Generic Stack");
                Console.WriteLine("3. Generic Queue");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your Choice (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunGenericDictionaryDemo();
                        break;
                    case "2":
                        RunGenericStackDemo();
                        break;
                    case "3":
                        RunGenericQueueDemo();
                        break;
                    case "4":
                        exit = true;
                        Console.WriteLine("Exiting Program...");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice. Try again.");
                        break;
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void RunGenericDictionaryDemo()
        {
            Console.WriteLine("\n=====Generic Dictionary Demo=====");

            GenericDictionary<int, string> dictionary = new GenericDictionary<int, string>();

            Console.Write("How many Entries you want to Add? ");
            if (int.TryParse(Console.ReadLine(), out int count))
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"Enter Key {i + 1} (int): ");
                    int key = Convert.ToInt32(Console.ReadLine());

                    Console.Write($"Enter Value {i + 1} (string): ");
                    string value = Console.ReadLine();

                    dictionary.Add(key, value);
                }
            }

            dictionary.DisplayDict();

            Console.Write("\nEnter Key to Remove: ");
            if (int.TryParse(Console.ReadLine(), out int removeKey))
            {
                dictionary.Remove(removeKey);
            }

            dictionary.DisplayDict();
        }

        static void RunGenericStackDemo()
        {
            Console.WriteLine("\n=====Generic Stack Demo=====");

            GenericStack<string> stack = new GenericStack<string>();

            Console.Write("How many Items you want to Push to the Stack? ");
            if (int.TryParse(Console.ReadLine(), out int count))
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"Enter Item {i + 1}: ");
                    string item = Console.ReadLine();
                    stack.PushItem(item);
                }
            }

            stack.DisplayStack();

            Console.Write("\nDo you want to Pop an Item? (Y/N): ");
            string popChoice = Console.ReadLine().ToLower();
            if (popChoice == "y")
            {
                stack.PopItem();
                stack.DisplayStack();
            }
        }

        static void RunGenericQueueDemo()
        {
            Console.WriteLine("\n=====Generic Queue Demo=====");

            GenericQueue<string> queue = new GenericQueue<string>();

            Console.Write("How many Items you want to Enqueue? ");
            if (int.TryParse(Console.ReadLine(), out int count))
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"Enter Item {i + 1}: ");
                    string item = Console.ReadLine();
                    queue.EnqueueItem(item);
                }
            }

            queue.DisplayQueue();

            Console.Write("\nDo you want to Dequeue an Item? (Y/N): ");
            string dequeueChoice = Console.ReadLine().ToLower();
            if (dequeueChoice == "y")
            {
                queue.DequeueItem();
                queue.DisplayQueue();
            }
        }
    }
}
*/