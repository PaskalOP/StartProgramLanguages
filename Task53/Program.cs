// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] resultArray = CreateArrayMatrix(3, 4, -10, 10);
PrintMayrix (resultArray);
Console.WriteLine();
ChangePlase(resultArray);
PrintMayrix (resultArray);

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

void PrintMayrix(int[,] arr)
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

void ChangePlase(int [,] matrix)
{
    int firstRow =0;
    int lastRow = matrix.GetLength(0);
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp =  matrix[firstRow, i];
        matrix[firstRow, i] = matrix [lastRow, i];
        matrix [lastRow, i] = temp;

    }
}