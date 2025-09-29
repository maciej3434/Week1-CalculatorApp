// Declared the variables and initialised them to 0.
int FirstNumber, SecondNumber, Result, choice = 0;

// Ask user for first number.
Console.WriteLine("Type in the first number followed by the Enter key");
int firstnumber = Convert.ToInt32(Console.ReadLine());

// Ask user for Second number.
Console.WriteLine("Type in the Second number followed by the Enter key");
int secondnumber = Convert.ToInt32(Console.ReadLine());


// Asks user to choose an option.
Console.WriteLine("Choose and option from the following list:");
Console.WriteLine("1 - Add");
Console.WriteLine("2 - Subtract");
Console.WriteLine("3 - Divide");
Console.WriteLine("4 - Multiply");

choice = Convert.ToInt32(Console.ReadLine());

if (choice == 1) 
{
    Result = FirstNumber + SecondNumber;
    Console.WriteLine($"Adding {FirstNumber} and {SecondNumber} equals {Result}");
}
else if (choice == 2)
{
    Result = FirstNumber - SecondNumber;
    Console.WriteLine($"Subtracting {FirstNumber} and {SecondNumber} equals {Result}");
}
else if (choice == 3)
{
    Result = FirstNumber / SecondNumber;
    Console.WriteLine($"Dividing {FirstNumber} and {SecondNumber} equals {Result}");
}
else if (choice == 4)
{
    Result = FirstNumber * SecondNumber;
    Console.WriteLine($"Multiplying {FirstNumber} and {SecondNumber} equals {Result}");
}
else
{
    Console.WriteLine("You have not typed a valid option between 1-4");
}