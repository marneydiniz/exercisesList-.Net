// 11 - Write a program in C# that prints the numbers from 5 to 10 on the screen.

int[] array = new int[11];
for (int i = 5; i < array.Length; i++)
{
    array[i] = i;
    Console.WriteLine(array[i]);
}
