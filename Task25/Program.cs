// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine ("Введите целое положительное число A");
int numberA = Convert.ToInt32(Console.ReadLine());
while (numberA<=0)
{
    Console.WriteLine ("Ви ввели не корректное число!");
    Console.WriteLine ("Введите целое положительное число A");
    numberA = Convert.ToInt32(Console.ReadLine());  
}

Console.WriteLine ("Введите целое положительное число B");
int numberB = Convert.ToInt32(Console.ReadLine());

while (numberB<=0)
{
    Console.WriteLine ("Ви ввели не корректное число!");
    Console.WriteLine ("Введите целое положительное число B");
    numberB = Convert.ToInt32(Console.ReadLine());  
}
double degreeOfNumber = DegreeOfNumber(numberA,numberB);
Console.WriteLine ($"{numberA } в степени  {numberB} равняется {degreeOfNumber}");

double DegreeOfNumber (int a, int b)
{
    double result=1;
    for (int i = 1; i <= b; i++)
    {
        result = result*a;
    }
    return result;
}