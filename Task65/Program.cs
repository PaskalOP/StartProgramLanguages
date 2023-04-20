// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите целое положительное число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое положительное число N");
int n = Convert.ToInt32(Console.ReadLine());

if ((m > 0) && (n > 0))
NaturalNumbers(m,n);
else
Console.WriteLine("Некорректный ввод.");


void NaturalNumbers (int firstNum, int secondNum)
{

    if (firstNum>secondNum)
    {
        Console.Write($"{firstNum} ");
        NaturalNumbers (firstNum-1,secondNum);
    }
    else if (firstNum<secondNum)
    {
      Console.Write($"{firstNum} ");
        NaturalNumbers (firstNum+1,secondNum);   
    }
    else Console.WriteLine($"{firstNum}");
}
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