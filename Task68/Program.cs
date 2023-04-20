// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Введите целое положительное число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое положительное число N");
int n = Convert.ToInt32(Console.ReadLine());

if ((m >= 0) && (n >= 0))
{
int result = AckermanFunction (m,n);
Console.WriteLine(result);
}
else
Console.WriteLine("Некорректный ввод.");

int AckermanFunction (int num1, int num2) 
{
   if (num1==0) return  num2+1;
   if(num2==0) return  AckermanFunction (num1-1,1);
   else return AckermanFunction(num1-1,AckermanFunction(num1, num2-1));
}
 
