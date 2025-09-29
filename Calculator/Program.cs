// Ask user for first number.
Console.WriteLine("Type in the first number followed by the Ender key");
int firstnumber = Convert.ToInt32(Console.ReadLine());

// Ask user for Second number.
Console.WriteLine("Type in the Second number followed by the Ender key");
int secondnumber = Convert.ToInt32(Console.ReadLine());

// Perform Calulation
int result = firstnumber + secondnumber;
Console.WriteLine("The addition of both numbers is {0}", result);
Console.ReadKey();