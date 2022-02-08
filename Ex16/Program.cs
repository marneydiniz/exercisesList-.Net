// 16 - Write a program in C# that reads an integer from the keyboard and makes the sum of the next 100 numbers, showing the result on screen.

Console.WriteLine("Input a number");
long number = Convert.ToInt64(Console.ReadLine());

long[] array = new long[number + 99];
long sum = 0;
for (long i = number; i < array.Length; i++)
{
    array[i] = i;
    sum = sum + array[i];
    Console.WriteLine(sum);
}