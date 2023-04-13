// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] resultArray = CreateArrayMatrix(7, 8, 0, 20);
PrintArray(resultArray);

Console.WriteLine("Введите номер строки");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int n = Convert.ToInt32(Console.ReadLine());


string resultOfFinding = FindElement(resultArray, m, n) == true ? $" Ваш элемент {resultArray[m - 1, n - 1]}" : "Такого числа нет в массиве";
Console.WriteLine(resultOfFinding);

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

bool FindElement(int[,] array, int rowNum, int columNum)
{
    return array.GetLength(0) >= rowNum && array.GetLength(1) >= columNum ? true : false;
}

