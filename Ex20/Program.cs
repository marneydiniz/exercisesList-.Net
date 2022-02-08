// 20 - Write a C# program that declares an integer variable B and assign it a value. It then displays a message indicating whether the value of B is positive or negative.
// We will consider 0 as positive.
// If for example B = 1 the output will be 1 is positive.If for example B = -1 the output will be: -1 is negative.


var B = -5;

if (B >= 0)
    Console.WriteLine($"{B} is positive");
else
    Console.WriteLine($"{B} is negative");

