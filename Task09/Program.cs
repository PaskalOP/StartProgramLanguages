// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int numberRandom = new Random().Next(10,100);
Console.WriteLine ($"Случайное число из диапазона 10-99: {numberRandom} ");
// ПЕРВЫЙ ВАРИАНТ
// int firstDigit = numberRandom/10;
// int secondDigit = numberRandom%10;
// if (firstDigit>secondDigit) Console.WriteLine ($"Большая цифра числа {firstDigit}" );
// else Console.WriteLine ($"Большая цифра числа {secondDigit}" );

//КОРОТКАЯ ЗАПИСЬ
// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа => {maxDigit}");


// СОЗДАЕМ МЕТОД
int MaxDigit (int numRandom)
{
    int firstDigit = numRandom/10;
    int secondDigit = numRandom%10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;
}
int maxDigit = MaxDigit (numberRandom);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit}");