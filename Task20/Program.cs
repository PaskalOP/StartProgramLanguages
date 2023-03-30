
// Math.Sqrt(5); квадрат 
// Math.Round(6,2, MidpointRounding.ToZero) где 6 - это число которое округляем, и 2 это до какой цифры после 0
// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату Х1:");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y1:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Х2:");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y2:");
int y2 = Convert.ToInt32(Console.ReadLine());

double findingDistance = FindDistance(x1,x2,y1,y2);


Console.WriteLine ($"Расстояние между точкой А и В = {Math.Round(findingDistance ,2, MidpointRounding.ToZero)}");

double FindDistance(int x1Coordinata, int x2Coordinata, int y1Coordinata, int y2Coordinata)
{
    int firstCatet = x2Coordinata - x1Coordinata;
    int secondCatet = y2Coordinata - y1Coordinata;
    double distance = Math.Sqrt(firstCatet*firstCatet+secondCatet*secondCatet);
    
    return distance;
}