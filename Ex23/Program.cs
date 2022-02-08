// 23 - Make a program that prints the 10 multiplication tables.

int[] table = new int[11];

for (int i = 0; i < table.Length; i++)
{
    table[i] = i;
    Console.WriteLine($"10 X {table[i]} = {10 * table[i]}");
}
