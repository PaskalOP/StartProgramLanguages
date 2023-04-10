// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите количество чисел Фибоначчи");
int userNumber = Convert.ToInt32(Console.ReadLine());
int[] fibArray = FibonachiNum(userNumber);
Console.WriteLine($"Первые {userNumber} чисел Фибоначчи: ");
PrintArray(fibArray);
Console.WriteLine();

int[] FibonachiNum(int num)
{
    int[] resultArray = new int[num];
    resultArray[0] = 0;
    resultArray[1] = 1;
    for (int i = 2; i < resultArray.Length; i++)
    {
        resultArray[i] = resultArray[i - 1] + resultArray[i - 2];
    }
    return resultArray;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }

}