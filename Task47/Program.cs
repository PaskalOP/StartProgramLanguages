
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк таблицы");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов таблицы");
int n = Convert.ToInt32(Console.ReadLine());

double[,] resultArray = CreateArrayMatrix(m, n, -10, 10);
PrintArray(resultArray);
Console.WriteLine();

double[,] CreateArrayMatrix(int rows, int colums, int min, int max)
{
    double[,] arr = new double[rows, colums];
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round((rand.NextDouble() * (max - min) + min), 2, MidpointRounding.ToZero);
        }
    }
    return arr;
}

void PrintArray(double[,] arr)
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