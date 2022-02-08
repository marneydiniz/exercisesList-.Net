// 14 - Write a program in C# that prints 200 times the word "hello". Note: in the source code that you write you must only enter once the word "hello".

string[] array = new string[200];
for (int i = 0; i < array.Length; i++)
{
    array[i] = "hello";
    Console.WriteLine(array[i]);
    Console.WriteLine(i);
}
