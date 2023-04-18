
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [ , , ] ThreeDimensionalArr()
{
    int [ , , ] resulrArray = new int [ 3, 3,3];
    Random random = new  Random();
    int firstNumX = random.Next(10,30);
    
    for (int i = 0; i < resulrArray.GetLength(0); i++)
    {
        firstNumX= firstNumX+resulrArray.GetLength(1);
     for (int j = 0; j < resulrArray.GetLength(1); j++)
     {
        firstNumX= firstNumX+resulrArray.GetLength(2);
        for (int k = 0; k < resulrArray.GetLength(2); k++)
        {
            resulrArray[i,j,k] = firstNumX+k;
            
        }
     }   
    }
    return resulrArray ;
}


void PrintThreeDimensionalArray (int [ , , ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write ($"{array[i,j,k],3} ({i}, {j}, {k})");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int [ , , ] treeDimArray = ThreeDimensionalArr();
PrintThreeDimensionalArray (treeDimArray );