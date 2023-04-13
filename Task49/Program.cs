// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int[,] resultArray = CreateArrayMatrix(3, 4, -10, 10);
PrintArray(resultArray);
Console.WriteLine("Сменили елементы на их квадраты");
ReplaseToSquare(resultArray );
PrintArray(resultArray);
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

void ReplaseToSquare ( int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            array[i,j] *= array[i,j];
        }
    }
}
