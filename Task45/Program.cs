// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int [] array = CreateArray(9,10,30);
PrintArray(array);
Console.WriteLine();
int [] newCopyArray = CopyArray(array);
newCopyArray [0] = -3;
Console.WriteLine("Hовый массив");
PrintArray(newCopyArray);
Console.WriteLine();


int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] CopyArray(int [] arr)
{
    int[] copyArr = new int[arr.Length];
   
    for (int i = 0; i < arr.Length; i++)
    {
        copyArr [i] = arr[i];
    }
    return copyArr;
}
