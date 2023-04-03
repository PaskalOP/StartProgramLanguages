// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int UserNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int result = SumNumbers(UserNumber);
Console.WriteLine($"Сумма цифер в числе = {result}");

int SumNumbers(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum +=num % 10;
        num /=  10;
    }
    return sum;
}