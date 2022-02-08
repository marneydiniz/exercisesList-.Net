// 28 - Write an algorithm that calls another name "add", which receives 2 numbers.
// The summation algorithm must add its parameters. The algorithm you invoke must receive that value and display it on the screen.

Console.WriteLine("Input Number 01: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Number 02: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum is {Add(num1, num2)}");

static int Add(int num1, int num2)
{
    return num1 + num2;
}