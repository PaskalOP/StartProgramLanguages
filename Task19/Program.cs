// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int userNunber = Convert.ToInt32(Console.ReadLine());

if (userNunber >= 100000 || userNunber < 10000)
{
    Console.WriteLine("Введите пятизначное число, которое больше 10000 и меньше 100000");
    userNunber = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(Palindrom(userNunber));
string Palindrom(int num)
{
    int first = num / 10000;
    int second = (num / 1000) % 10;
    int fourth = (num / 10) % 10;
    int fifth = num % 10;
    Console.WriteLine($" {first}, {second}, {fourth}, {fifth}");
    if (first == fifth && second == fourth) return "Число является палиндромом";
    else return "число не является палиндромом";

}