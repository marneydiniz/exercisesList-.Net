// 30 - Write a program that asks for a numerical password and allows three attempts.
// If the user enters the correct password, it shows "Correct!" And run any program, after the message.
// Otherwise the program should display "Wrong password".
// Then finish the program immediately.


long validPassword = 123456;
long input = 000000;
int count = 0;

do
{
    Console.WriteLine("Enter Password: ");
    input = Convert.ToInt64(Console.ReadLine());

    if (input == validPassword)
    {
        Console.WriteLine("Success!!");
        count = 4;
    }
    else
    {
        Console.WriteLine("Wrong Password!!");
        count++;
    }
}
while (count < 3);