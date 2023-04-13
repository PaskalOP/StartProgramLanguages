// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] resultArray = CreateArrayMatrix(3, 4, -10, 10);
PrintArray(resultArray);
Console.WriteLine();
int sum = SumElementsDiagonal(resultArray);
Console.WriteLine($"Сумма елементов диагонали равна {sum }");
int[,] CreateArrayMatrix(int rows, int colums, int min, int max)
{
    int[,] arr = new int[rows, colums];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i < arr.Length - 1) Console.Write($"{arr[i, j],3} ");
            else Console.Write($"{arr[i, j]}");
        }
        Console.WriteLine();
    }

}

int SumElementsDiagonal (int [,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0)&&i < array.GetLength(1); i++)
    {
        sum += array[i, i];
    }
    return sum;
}
