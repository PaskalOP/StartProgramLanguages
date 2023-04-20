
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите целое положительное число");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber > 0)
{
     Console.Write("\"");
    NaturalNumbers(userNumber);
     Console.Write("1\" ");
     Console.WriteLine();
}
else Console.WriteLine("Некоректный вход");

void NaturalNumbers(int num)
{
   
    if (num == 1) return ;
    Console.Write($"{num}, ");
    NaturalNumbers(num - 1);
   
}