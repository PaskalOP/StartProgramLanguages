
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] resultArray = CreateArrayMatrix(5, 5, 0, 20);
PrintMayrix(resultArray);

Console.WriteLine();
double[] AverageArray = FindAverageOfColums(resultArray);
PrintArray(AverageArray);
Console.WriteLine();
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

double[] FindAverageOfColums(int[,] matrixArray)
{
    double[] results = new double[matrixArray.GetLongLength(1)];
    for (int i = 0; i < matrixArray.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrixArray.GetLength(0); j++)
        {
            sum += matrixArray[i, j];
        }
        results[i] = Math.Round( sum/matrixArray.GetLength(0), 2, MidpointRounding.ToZero);
       
    }
    return results;
}

void PrintArray(double[] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {

        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");

    }

}
// Почему нельзя передать в качестве аргумента var [] array в метод PrintArray ?
// Почему double sum  нужно ставить тип дабл, почему вар не работает?

