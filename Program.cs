

Console.WriteLine($"Enter first digit: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"You typed: {number}");

Console.WriteLine("Choose operation: +, -, *, /");
string operation = Console.ReadLine();
Console.WriteLine($"You chose: {operation}");

Console.WriteLine("Enter Second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"You entered: {number2}");

if (operation == "+"){
    int result = number + number2;
    Console.WriteLine($"{result}");   
}
else if (operation == "-"){
    int result = number - number2;
    Console.WriteLine($"{result}");
}

if (operation == "*"){
    int result = number * number2;
    Console.WriteLine($"{result}");
}
else if (operation == "/")
{
    if (number2 != 0)
    {
        decimal result = (decimal)number / (decimal)number2;
        Console.WriteLine($"{number} / {number2} = {result}");
    }
    else
    {
        Console.WriteLine("Error: Cannot divide by zero.");
    }
}
