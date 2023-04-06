// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] array = CreateArray(12, -9, 9);
PrintArray(array);
Console.WriteLine();

Console.WriteLine($"Введите число, которое будем искать в массиве:");
int searchNum = Convert.ToInt32(Console.ReadLine());

bool result = FindElement(array, searchNum);

Console.WriteLine(result?$" Число {searchNum } есть в массиве":$" Числа {searchNum } нет в массиве");
// if (result) Console.WriteLine($" Число {searchNum } есть в массиве");
// else Console.WriteLine($" Числа {searchNum } нет в массиве");



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

bool FindElement (int [] arr, int findNum)
{
     for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]==findNum) return true;
    }
    return false;
}

