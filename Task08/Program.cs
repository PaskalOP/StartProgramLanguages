// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
    Console.WriteLine("Введите положительное  число: ");
    number = Convert.ToInt32(Console.ReadLine());
}
if (number > 0)
{
    Console.Write($" Ряд чётных чисел от 1 до {number}: ");
    for (int i = 2; i <= number; i += 2)
    {
        Console.Write($" {i}");
    }
     Console.WriteLine();
}
