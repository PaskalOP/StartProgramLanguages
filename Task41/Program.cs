// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
//больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
Console.WriteLine ("Co скольки чисел будет состоять массив?");
int countOfElements = Convert.ToInt32(Console.ReadLine());
int [] userArrar = InputNumbers (countOfElements);

Console.WriteLine ("Пользователь ввел такие числа:");
PrintArray (userArrar );
Console.WriteLine ();
Console.WriteLine ($"В этом массива {MoreThenZiro(userArrar)} чисел больше 0");

int [] InputNumbers (int num)
{
   int [] userArray = new int [num] ; 
  for (int i = 0; i < num; i++)
  {
    Console.WriteLine ($"Введите {i+1}e число");
    int userNumber = Convert.ToInt32 (Console.ReadLine());
    userArray[i] = userNumber ;
  }
  return userArray;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }

}

int MoreThenZiro (int[] arr)
{
    int count = 0;
    foreach (var item in arr)
    {
        if (item>0) count++;
    }
    return count;
}