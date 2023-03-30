// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.WriteLine("Сколько чисел возвести в квадрат");
int quantity = int.Parse(Console.ReadLine());


Square(quantity);

void Square(int userNumber)
{
    for (int i = 1; i <= userNumber; i++)
    {
        Console.WriteLine($"|{i,4}|{i * i,4}|");
    }
}

//{i,4} 4 - это количество символов в {}

