// 29 - Write an algorithm and a sub-algorithm. Write two variables with the same name and the compiler does not show error.

Console.WriteLine("Input Number 01: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Number 02: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum is {Add(num1, num2)}");

static int Add(int num1, int num2)
{
    return num1 + num2;
}