// 9 - Write a program in C# that prints the numbers 1 to 9 on the screen.

int[] array = new int[9];
for (int i = 0; i < array.Length; i++) 
{
    array[i] = i + 1;
    Console.WriteLine(array[i]);
}
