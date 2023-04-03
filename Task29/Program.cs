// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 1, 33, 6]


int[] array = new int[8];

FillArray(array);
Console.WriteLine("Массив из 8 элементов:");
PrintArray(array);
Console.Write($" -> ");
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();


void FillArray(int[] userArray)
{
    Random num = new Random();
    for (int i = 0; i < userArray.Length; i++)
    {
        userArray[i] = num.Next(0, 100);
    }
}

void PrintArray(int[] userArray)
{

    for (int i = 0; i < userArray.Length; i++)
    {
        if (i != userArray.Length - 1)
        {
            Console.Write($"{userArray[i]},");
        }
        else Console.Write($"{userArray[i]}");
    }
    
}