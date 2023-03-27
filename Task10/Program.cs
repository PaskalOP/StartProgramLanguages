// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int userNumberConsole = Convert.ToInt32(Console.ReadLine());
int checkedUserNumber = CheckedNumber (userNumberConsole);
int secondDigit = FindSecondFromTree(checkedUserNumber);

Console.WriteLine($"Вторая цифра в данном числе: {secondDigit}");

int FindSecondFromTree(int num)
{
     int num1 = num / 10;
     int result = num1 % 10;
     return result;
 }

int CheckedNumber (int userNumber)
{
   while (userNumber>999 || userNumber<100)
    
    {
        Console.WriteLine("Вы ввели не НЕ ТРЕХЗНАЧНОЕ число: ");
        Console.WriteLine("Введите трехзначное число: ");
        userNumber = Convert.ToInt32(Console.ReadLine());
    } 
     
    return userNumber;
}
