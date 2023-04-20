/*
int FactorialRec(int n)
 {
     if (n == 1) return 1;
     else return n * FactorialRec(n - 1);
 }

 Console.WriteLine(FactorialRec(10)); // 3628800*/
//  Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите целое положительное число ");
int m = Convert.ToInt32(Console.ReadLine());
int sumDigits = SumDigits(m);
Console.WriteLine(sumDigits);


int SumDigits(int num)
{
    return num == 0 ? 0 : num % 10 + SumDigits(num / 10);//453 -45 -4 
        //if (num == 0) return 0;
    //else return num%10 + SumDigits (num / 10);
}
