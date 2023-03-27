// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int UserNumber = Convert.ToInt32(Console.ReadLine());

if (UserNumber < 100) Console.WriteLine("Число не имеет третьей цифры");
else Console.WriteLine(FindThirdDigit(UserNumber));

int FindThirdDigit(int number)
{
    int findedDigit;

    if (number / 100 == 0)
    {
        findedDigit = number % 10;
    }
    else
    {
        while (number >= 1000)
        {
            number = number / 10;

        }
        findedDigit = number % 10;
    }
    return findedDigit;
}