using BASIC;
using System;

Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to C# .NET Progamming Language.");
MethodDemo();

Console.WriteLine();

PersonDetails();
static void MethodDemo()
{
    int number = 10;
    string greeting = "Hello, C#";

    Console.WriteLine($"Number: {number} and String: {greeting}");              // Prevoius type of variable incorporation
}

Console.WriteLine();

/*
LoopsDemo();
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

Console.WriteLine();

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

StudentDatabase studentDb = new StudentDatabase();
studentDb.DisplayStudentMarks();

// int result = Calculator();
// Console.WriteLine($"RESULT: {result}");

/*
static int Calculator()
{
    Calci cal = new Calci();                                        // Integrating the Calci class from BASIC namespace
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