// 10 - Write a program in C# that prints on the screen the numbers from 1 to 10,000.

int[] array = new int[10000];
for (int i = 0; i < array.Length; i++)
{
    array[i] = i + 1;
    Console.WriteLine(array[i]);
}