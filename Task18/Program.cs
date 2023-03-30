// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
int quarter = int.Parse(Console.ReadLine());

string result = Quarter(quarter);

Console.WriteLine($"Диапазон координат: {result}");

string Quarter(int x)
{
    if (x == 1) return "X > 0, Y > 0";
    if (x == 2) return "X < 0, Y > 0";
    if (x == 3) return "X < 0, Y < 0";
    if (x == 4) return "X > 0, Y < 0";

    return "Нет такой четверти";
}
