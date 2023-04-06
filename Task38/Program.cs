// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
int min = 10;
int max = 20;
double[] array = CreateArrayRndDouble(10, min,max);
PrintArray(array);
Console.WriteLine();
double maxElement = Math.Round(MaxElement(array,min), 2, MidpointRounding.ToZero);
double minElement = Math.Round(MinElement(array, max), 2, MidpointRounding.ToZero);
double differance = maxElement - minElement;
Console.WriteLine($"Разница между максимальным и минимальным елементом массива: {maxElement} - {minElement} = {differance}");

double[] CreateArrayRndDouble(int size, int minEl, int maxEl)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (maxEl - minEl) + minEl;
    }
    return arr;
}
double MaxElement(double[] arr, int minFromDiapazone)
{
    double maxElememt = minFromDiapazone;
    foreach (var item in arr)
    {
        if (item > maxElememt) maxElememt = item;
    }
    return maxElememt;
}
double MinElement(double[] arr, int maxFromDiapazone)
{
    double minElememt = maxFromDiapazone;
    foreach (var item in arr)
    {
        if (item < minElememt) minElememt = item;
    }
    return minElememt;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{Math.Round(arr[i], 2, MidpointRounding.ToZero)}; ");
        else Console.Write($"{Math.Round(arr[i], 2, MidpointRounding.ToZero)}");
    }
    Console.Write("]");
}



