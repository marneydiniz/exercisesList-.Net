// 18 - Write a program in C# that reads two numbers on the keyboard and say which is the largest and which is the smallest.

Console.WriteLine("Input Number 1: ");
var num1 = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Input Number 2: ");
var num2 = Convert.ToInt64(Console.ReadLine());

if (num1 == num2)
    Console.WriteLine("The numbers are equals.");
else if (num1 > num2)
    Console.WriteLine($"{num1} is largest than {num2}.");
else if(num1 < num2)
    Console.WriteLine($"{num1} is smallest than {num2}.");
