// 24 - Make a calculator.

Console.WriteLine("*** CALCULATOR ***");

Console.WriteLine("Input number 1: ");
var num1 = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Input number 2: ");
var num2 = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Choose Operation '+' '-' '*' '/' :");
var op = Console.ReadLine();

switch (op)
{
    case "+":
        Console.WriteLine($"Result: {num1 + num2}");
        break;
    case "-":
        Console.WriteLine($"Result: {num1 - num2}");
        break;
    case "*":
        Console.WriteLine($"Result: {num1 * num2}");
        break;
    case "/":
        Console.WriteLine($"Result: {num1 / num2}");
        break;
    default:
        Console.WriteLine("Invalid Entry");
        break;
}