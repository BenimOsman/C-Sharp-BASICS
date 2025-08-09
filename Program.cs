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

// SingleInh();

/*
static void SingleInh()
{
    SingleInh employeee = new SingleInh();
    Console.WriteLine("Enter Employee ID: ");
    employeee.EmployeeID = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Employee Name: ");
    employeee.Name = Console.ReadLine();
    Console.WriteLine("Enter Employee Age: ");
    employeee.Age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Employee Address: ");
    employeee.Address = Console.ReadLine();
    Console.WriteLine("Enter Employee Phone No.: ");
    employeee.PhoneNumber = Console.ReadLine();
    Console.WriteLine("Enter Employee Email: ");
    employeee.Email = Console.ReadLine();
    Console.WriteLine("Enter Employee Occupation: ");
    employeee.Occupation = Console.ReadLine();
    Console.WriteLine("Enter Employee Department: ");
    employeee.Department = Console.ReadLine();
    
    // employeee.DisplayPersonDetails();
    employeee.DisplayEmployeeDetails();
}
*/

// MultiLInh();

