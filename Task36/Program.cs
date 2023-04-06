// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = CreateArray(12, -20, 50);
PrintArray(array);
Console.WriteLine();
int summOddElements = SummOddElements(array);

Console.WriteLine($"Сумма елементов, стоящих на нечетных позициях равна {summOddElements}");


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

int SummOddElements(int[] arr)
{
    int summ = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
          summ +=arr[i];
    }
    return summ;
}