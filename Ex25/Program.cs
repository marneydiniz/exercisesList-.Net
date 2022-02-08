// 25 - Calculate the salary increase for a group of employees of a company considering the following criteria:
// If the salary is less than $ 1,000.00: Increase 15%
// If the salary is greater than or equal to $ 1,000.00: Increase 12%
// The program must do The following:
// - Save the new salaries in the arrangement
// - Calculate the payroll
// - Print the salaries from the settlement

double[] salary = new double[5] { 1200, 1500, 900, 800, 2000 };
double payroll = 0;

for (int i = 0; i < salary.Length; i++)
{
    if (salary[i] < 1000)
        salary[i] = salary[i] + (salary[i] * 0.15);
    else
        salary[i] = salary[i] + (salary[i] * 0.12);

    payroll += salary[i];
    Console.WriteLine(salary[i]);
}

Console.WriteLine($"Payroll is {payroll}");