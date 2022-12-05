// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int m = 3;
int n = 3;
int[,] array = new int[m, n];

PrinArray(FillArray(array));
PrinArray(SortElementsArray(array));

int[,] FillArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 11);

        }
    }
    return arr;
}

int[,] SortElementsArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1)-1; j++)
        {
            if (ar[i, j] <= ar[i, j + 1])
            {
                int temp = ar[i, j];
               
                ar[i, j] = ar[i, j + 1];
                ar[i, j + 1] = temp;
            }

        }

    }
    return ar;
}

void PrinArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            Console.Write($"{ar[i, j]} ");

        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}