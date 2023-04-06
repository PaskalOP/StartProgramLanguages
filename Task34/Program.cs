// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = CreateArray(12, 100, 999);
PrintArray(array);
Console.WriteLine();
int evenNumbersCount = CountEvenNumbers(array);

Console.WriteLine($"Количество четных чисел в массиве равно {evenNumbersCount}");


int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int CountEvenNumbers(int[] arr)
{
    int result = 0;
    foreach (int element in  arr)
    {
        if (element %2==0) result ++;

    }
    return result;
}