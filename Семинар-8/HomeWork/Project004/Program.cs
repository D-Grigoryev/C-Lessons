// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int [,,] array = new int [2,2,2];
FillArray(array);
PrintArrayWithIndexes(array);

int[,,] FillArray(int[,,] arrayToFill)
{
    for (int i = 0; i < arrayToFill.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToFill.GetLength(1); j++)
        {
            for (int k = 0; k < arrayToFill.GetLength(2); k++)
            {
                int value =new Random().Next(10, 100);
                
                if (Validator(arrayToFill, value)){
                arrayToFill[i, j, k] = value;
                }else {
                    value = new Random().Next(10, 100);
                     arrayToFill[i, j, k] = value;
                }
            }
        }
    }
    return arrayToFill;
}

void PrintArrayWithIndexes(int[,,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            for (int k = 0; k < arrayToPrint.GetLength(2); k++)
            {
                Console.WriteLine(arrayToPrint[i, j, k] + " (" + i + "," + j + "," + k + ")");
            }
        }
    }
    Console.WriteLine();
}

bool Validator (int[,,] arrayToFill, int checkElement)
{
    for (int i = 0; i < arrayToFill.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToFill.GetLength(1); j++)
        {
            for (int k = 0; k < arrayToFill.GetLength(2); k++)
            {
                if (checkElement == arrayToFill[i,j,k]) 
                {
                    return false;
                    }
            }
        }
    }
    return true;
}

