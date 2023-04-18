// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7


Console.WriteLine("Введите количество строк таблицы");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов таблицы");
int n = Convert.ToInt32(Console.ReadLine());

int[,] resultArray = CreateArrayMatrix(m, n, 0, 10);
PrintArray(resultArray);
Console.WriteLine();
int[] arrayIndexes = MinElementOfMatrix(resultArray);
int[,] matrixWithoutMinElement = RemoveRowColumnMinElement(resultArray, arrayIndexes);
PrintArray(matrixWithoutMinElement);
Console.WriteLine();

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

int[] MinElementOfMatrix(int[,] arr)
{
    int[] indexes = new int[] { 0, 0 };

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < arr[indexes[0], indexes[1]])
            {
                indexes[0] = i;
                indexes[1] = j;
            }
        }
    }
    return indexes;
}

int[,] RemoveRowColumnMinElement(int[,] originalMatrix, int[] indexes)
{
    int[,] newMatrix = new int[originalMatrix.GetLength(0) - 1, originalMatrix.GetLength(1) - 1];
    int m =0;
    int n =0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (m==indexes[0]) m++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (n==indexes[1]) n++;
            
            newMatrix[i, j] = originalMatrix[m, n];
            n++;   
        }
        m++;
        n=0;
    }
    return newMatrix ;
}
