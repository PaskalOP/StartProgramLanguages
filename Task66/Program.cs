// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое число M");
int firstNum = Convert.ToInt32(Console.ReadLine()); //условно меньшее

Console.WriteLine("Введите целое число N");
int secondNum = Convert.ToInt32(Console.ReadLine()); //условно большее

if (firstNum<=secondNum)
{
 int result1 = SumNumbers(firstNum, secondNum);
 Console.WriteLine($"Сумма натуральных чисел {result1} ");
}
else
{
 int result2 = SumNumbers(secondNum,firstNum);
 Console.WriteLine($"Сумма натуральных чисел {result2} ");
}


int SumNumbers(int num1, int num2)
{
    if (num2>0)
    {
        return num2==0||num2==num1-1?0:num2+SumNumbers(num1,num2-1);
    }
    else return 0;

}