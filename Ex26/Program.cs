// 26 - Make a program that asks for the salary of N workers (first you must ask how many workers there are) and print the one with the highest salary.

Console.WriteLine("Set the number of workers: ");
int workers = Convert.ToInt32(Console.ReadLine());

decimal[] salaries = new decimal[workers];
decimal maxSalary = 0;

for (int i = 0; i < salaries.Length; i++)
{
    Console.WriteLine($"Salary {i + 1}:");
    salaries[i] = Convert.ToDecimal(Console.ReadLine());
}

for (int i = 0; i < salaries.Length; i++)
{
    if (salaries[i] >= maxSalary)
    {
        maxSalary = salaries[i];
    }
}

Console.WriteLine($"The max salary is {maxSalary}");