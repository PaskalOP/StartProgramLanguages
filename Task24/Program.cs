// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.

Console.WriteLine ("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumNumbers(number);
Console.WriteLine($"Сумма сисел от 1 до {number } = {result }");

int SumNumbers (int num)
{
    int sum =0;
    for (int i = 1; i<=num; i++) sum+=i;
 return sum;
}