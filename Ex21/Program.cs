// 21 - Make a program in C# such that given as data the enrolment and 5 grades of a student; Print the enrolment, the average and the word "approved" if the student has an average
// greater than or equal to 6, and the word "not approved" otherwise. Data: MAT, CAL1, CAL2, CAL3, CAL4, CAL5 Where: MAT is an integer variable that represents the student's enrolment.
// CAL1, CAL2, CAL3, CAL4 and CAL5 are real-type variables representing the student's 5 grades.

double[] grades = new double[5] { 0.0, 9.9, 7.5, 4.6, 5.0 };
double sum = 0;

for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"Grade: {grades[i]}");
    sum += grades[i];
}

double average = sum / grades.Length;

if (average >= 6)
    Console.WriteLine($"The Average is {average} - Approved");
else
    Console.WriteLine($"The Average is {average} - Not Approved");
