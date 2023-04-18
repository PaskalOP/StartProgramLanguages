// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество строк таблицы");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов таблицы");
int n = Convert.ToInt32(Console.ReadLine());

int[,] resultArray = CreateArrayMatrix(m, n, 0, 10);
PrintArray(resultArray);
Console.WriteLine();
SortRows(resultArray);
Console.WriteLine("Массив с упорядоченными по убыванию элементами каждой строки");
PrintArray(resultArray);

int[,] CreateArrayMatrix(int rows, int colums, int min, int max)
{
    int[,] arr = new int[rows, colums];
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(min, max);
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
            if (i < arr.Length - 1) Console.Write($"{arr[i, j],5} ");
            else Console.Write($"{arr[i, j]}");
        }
        Console.WriteLine();
    }
}

void SortRows(int[,] originMatrix)
{
    for (int i = 0; i < originMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < originMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < originMatrix.GetLength(1)-1; k++)
            {
                int temp = originMatrix[i, k];
                if (originMatrix[i,k+1] > temp)
                {
                   temp = originMatrix[i,k+1];
                   originMatrix[i,k+1] =originMatrix[i, k];
                   originMatrix[i, k]= temp;
                }
            }
        }
    }
}