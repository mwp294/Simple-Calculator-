using System.Numerics;

Console.WriteLine("Hello");
Console.WriteLine("Input the first number:");

var userChoice = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the second number:");

var userChoice2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");

var userChoice3 = Console.ReadLine();

int result;

if (userChoice3 == "A" || userChoice3 == "a")
{
    result = userChoice + userChoice2;
    Console.WriteLine($"{userChoice} + {userChoice2} = "  + result);         
}
else if (userChoice3 == "S" || userChoice3 == "s")
{
    result = userChoice - userChoice2;
    Console.WriteLine($"{userChoice} - {userChoice2} = " + result);
}
else if (userChoice3 == "M" || userChoice3 == "m")
{
    result = userChoice * userChoice2;
    Console.WriteLine($"{userChoice} * {userChoice2} = " + result);
}
else 
{
    Console.WriteLine("Invalid Choice!");
}
Console.WriteLine("Press Any Key to Close");

Console.ReadKey();