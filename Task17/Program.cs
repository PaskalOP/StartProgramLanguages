// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.


Console.WriteLine ("Введите координату Х:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите координату Y:");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(x,y);
string result = quarter>0? $"Номер четверти, в которой находится точка -> {quarter}"
: $"Некорректный ввод данных.";

Console.WriteLine (result);

int Quarter(int xCoordinate, int yCoordinate)
{
    if (xCoordinate>0&&yCoordinate>0) return 1;
    if (xCoordinate>0&&yCoordinate<0) return 4;
    if (xCoordinate<0&&yCoordinate<0) return 3;
    if (xCoordinate<0&&yCoordinate>0) return 2;
    return 0;
}