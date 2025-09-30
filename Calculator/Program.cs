// Declared the variables and initialised them to 0.
using System;

int FirstNumber, SecondNumber, Result = 0, choice = 0;

try
{
    // Ask user for first number.
    Console.WriteLine("Type in the first number followed by the Enter key");
    FirstNumber = Convert.ToInt32(Console.ReadLine());

    // Ask user for Second number.
    Console.WriteLine("Type in the Second number followed by the Enter key");
    SecondNumber = Convert.ToInt32(Console.ReadLine());


    // Asks user to choose an option.
    Console.WriteLine("Choose and option from the following list:");
    Console.WriteLine("+ - Add");
    Console.WriteLine("- - Subtract");
    Console.WriteLine("/ - Divide");
    Console.WriteLine("* - Multiply");

    choice = Convert.ToChar(Console.ReadLine());

    switch (choice) 
    {
        case '+':
            Result = FirstNumber + SecondNumber;
            break;
        case '-':
            Result = FirstNumber - SecondNumber;
            break;
        case '/':
            Result = FirstNumber / SecondNumber;
            break;
        case '*':
            Result = FirstNumber * SecondNumber;
            break;
    }
    Console.WriteLine($"Result: {Result}");
}
catch (FormatException ex)
{
    // Handle the case where the input is not valid
    Console.WriteLine("Please enter a valid number.");
}
catch (DivideByZeroException ex)
{
    // Handle the case where the input is not valid
    Console.WriteLine($"You cannot divide by zero.");
}
catch (Exception ex)
{
    Console.WriteLine($"Error:{ex.Message}. Please enter a valid operation.");
}
finally 
{
    Console.WriteLine("Operation completed.");ik
}