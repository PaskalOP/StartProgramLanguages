/*
int FactorialRec(int n)
 {
     if (n == 1) return 1;
     else return n * FactorialRec(n - 1);
 }

 Console.WriteLine(FactorialRec(10)); // 3628800*/

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите целое положительное число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое положительное число N");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 0)
{
    int result = DegreeOfNumber(m, n);
    Console.WriteLine(result);
}
else
    Console.WriteLine("Некорректный ввод.");


int DegreeOfNumber(int a, int b)
{
    return b == 0 ? 1 : a * DegreeOfNumber(a, b - 1); //2,3-2,2-2,1-//1*2*2*2
    //if (b == 0) return 1;
    //else return a * DegreeOfNumber (a,b - 1);

}
