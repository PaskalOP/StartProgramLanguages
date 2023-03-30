// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Сколько чисел возвести в квадрат?");
int numberN = Convert.ToInt32(Console.ReadLine());
while (numberN<=0)
{
    Console.WriteLine("Введи положительное цело число, больше нуля");
    numberN = Convert.ToInt32(Console.ReadLine());
}

Cube(numberN);

void Cube(int userNumber)
{
    for (int i = 1; i <= userNumber; i++)
    {
        Console.WriteLine($"|{i,4}|{i * i* i,4}|");
    }
}