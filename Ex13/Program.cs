// 13 - Write a program in C# that prints on the screen the numbers from 5 to 15,000.

int[] array = new int[15001];
for (int i = 5; i < array.Length; i++)
{
    array[i] = i;
    Console.WriteLine(array[i]);
}
