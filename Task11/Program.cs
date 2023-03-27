// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int numRandom = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из диапазона 100-999: {numRandom} ");

int newNum = DelSecondDigit(numRandom );
Console.WriteLine($"Новое двузначное число: {newNum } ");


int DelSecondDigit(int randomNumber)
{
    int firstNumber = randomNumber / 100;
    int thirdNumber = randomNumber % 10;
    int newNumber = firstNumber * 10 + thirdNumber;
    return newNumber;
}

