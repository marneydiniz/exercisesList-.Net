// 22 - Make the program in C# such that given as a worker's salary, apply a 15% increase if your salary is less than $ 1000 and 12% otherwise.
// Print the new salary of the worker. Fact: SUE (variable of real type that represents the salary of the worker).

double salary = 100;

if (salary < 1000)
    salary = salary + (salary * 0.15);
else
    salary = salary + (salary * 0.12);

Console.WriteLine(salary);