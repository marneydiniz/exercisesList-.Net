// 17 - Write a program in C# that converts from Canadian dollars to US dollars. You will receive a decimal number corresponding to the amount in CAD and will answer with
// the corresponding amount in US dollars. Take the quotation of the dollar today.

decimal cadValue, cadQuatation = 0.79M, usValue;

Console.WriteLine("Input a CAD dolars");
cadValue = Convert.ToDecimal(Console.ReadLine());

usValue = cadValue * cadQuatation;

Console.WriteLine(usValue);