
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FullSpiralMatrix(int num)
{
    int[,] spiral = new int[num, num];
    int value = 1;
    int minRow = 0;
    int maxRow = spiral.GetLength(0) - 1;
    int minCol = 0;
    int maxCol = spiral.GetLength(1) - 1;
    while (value <= spiral.GetLength(0) * spiral.GetLength(1))
    {
        for (int i = minRow; i <= maxCol; i++)
        {
            spiral[minRow, i] = value;
            value++;
        }
        minRow++;

        for (int i = minRow; i <= maxRow; i++)
        {
            spiral[i, maxCol] = value;
            value++;
        }
        maxCol--;
        for (int i = maxCol; i >= minCol; i--)
        {
            spiral[maxRow, i] = value;
            value++;
        }
        maxRow--;
        for (int i = maxRow; i >= minRow; i--)
        {
            spiral[i, minCol] = value;
            value++;
        }
        minCol++;
    }
    return spiral;
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
Console.WriteLine("Введите размерность квадратного массива");
int m = Convert.ToInt32(Console.ReadLine());

int [,] spiraleMatrix = FullSpiralMatrix(m);
PrintArray(spiraleMatrix);

