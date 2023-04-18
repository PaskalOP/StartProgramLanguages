// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
//находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите количество строк таблицы");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов таблицы");
int n = Convert.ToInt32(Console.ReadLine());

int[,] resultArray = CreateArrayMatrix(m, n, 0, 10);
PrintArray(resultArray);
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов {FindRowOfMinimalSumTltments(resultArray)}");

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

int FindRowOfMinimalSumTltments(int[,] matrix)
{
    int numberOfRow = 0;
    
    int minSumOfRow= int.MaxValue;
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
            
        }
        //Console.WriteLine ($"Сумма {i+1} строки = {sum}");
        
        if (sum<minSumOfRow)
        {
            minSumOfRow  = sum;
            numberOfRow = i+1;
           
        }
    }
    return numberOfRow;
}