// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int m = 3;
int n = 3;
int[,] array = new int[m, n];

PrinArray(FillArray(array));
PrinArray(ChangeString(array));

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

int [,] ChangeString(int[,] ar)
{
    int [] firstString  = new int [ar.GetLength(1)];
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            if (i==0){
                firstString [j] = ar[i,j];
            } 
            if (i == ar.GetLength(0)-1){
                ar[0,j] = ar[i,j]; 
                ar[ar.GetLength(0)-1,j] = firstString [j];
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