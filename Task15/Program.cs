// Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число, чтоб узнать выходной в этот день или нет: ");
int UserNumber = Convert.ToInt32(Console.ReadLine());
int boolNum =  Weekend (UserNumber);
PrintResult (boolNum);

int Weekend (int userInput)
{
    int result;
    if (userInput==6||userInput==7) result=1;
    else if (userInput>0 && userInput<6) result=-1;
    else result=0;
    return result;
}

void PrintResult (int resultBool)
{
    if (resultBool==1) Console.WriteLine ("Да - это выходной");
    else if (resultBool==-1) Console.WriteLine ("Нет - это НЕ выходной");
    else Console.WriteLine ("Нет дня недели под этой цифрой");
}