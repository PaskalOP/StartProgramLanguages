// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк первой  таблицы");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов первой таблицы");
int n = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = CreateArrayMatrix(m, n, 0, 10);

Console.WriteLine("Введите количество строк второй таблицы");
int p = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов второй таблицы");
int t = Convert.ToInt32(Console.ReadLine());

int[,] secondMatrix = CreateArrayMatrix(p, t, 0, 10);
Console.WriteLine("Перемножим массив");
PrintArray(firstMatrix);
Console.WriteLine("С массивoм");
PrintArray(secondMatrix);
Console.WriteLine("Итоговый массив");
int [,] multiplyArray = MultiplyMatrix(firstMatrix,secondMatrix);
PrintArray(multiplyArray);

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

int [,] MultiplyMatrix(int [,] firstArr, int [,]secondArr)
{
    int [,] resultArr = new int [firstArr.GetLength(0),secondArr.GetLength(1)];
    if (firstArr.GetLength(0) !=secondArr.GetLength(1)&&firstArr.GetLength(1) !=secondArr.GetLength(0)) Console.WriteLine("Количество строк первого массива и количество столбцов второго массива должны совпадать");
   
    for (int i = 0; i < resultArr.GetLength (0); i++)
    {
        for (int j = 0; j < resultArr.GetLength (1); j++)
            {
                int sum =0;
                for (int k = 0; k < resultArr.GetLength(0); k++)
                {
                    sum +=firstArr[i,k]*secondArr[k,j];
                }
                resultArr[i,j]=sum;
            }        
    }
        return resultArr;
  
}