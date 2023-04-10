// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значения k1, b1, k2 и b2:");
double k1 = double.Parse(Console.ReadLine());
double b1 = double.Parse(Console.ReadLine());
double k2 = double.Parse(Console.ReadLine());
double b2 = double.Parse(Console.ReadLine());


double [] pointOfCr= PointOfCrossed (k1, b1,k2,b2);
PrintResult (pointOfCr);

void PrintResult(double[] arr)
{
    if (k1 == k2) Console.WriteLine("Линии параллельны и не пересекаются");
    else Console.WriteLine($"Точка пересечения: ({arr[0]}, {arr[1]})");
}

double[] PointOfCrossed(double x1, double y1, double x2, double y2)
{
    double[] pointOfCrossed = new double[2];
    pointOfCrossed[0] = Math.Round((y2 - y1) / (x1 - x2), 2, MidpointRounding.ToZero);
    pointOfCrossed[1] = Math.Round(x1 * pointOfCrossed[0] + y1, 2, MidpointRounding.ToZero);
    return pointOfCrossed;
}
