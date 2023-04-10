// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите длину первой стороны");
int firstSide = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны");
int secondSide = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину третьей стороны");
int thirdSide = Convert.ToInt32(Console.ReadLine());

bool result = IsTriangle(firstSide , secondSide, thirdSide );
string res = result? "Треугольник с данными сторонами может существовать": "Треугольник с данными сторонами не может существовать";
Console.WriteLine (res);

bool IsTriangle(int num1, int num2, int num3)
{
    return  num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2;
   
}
