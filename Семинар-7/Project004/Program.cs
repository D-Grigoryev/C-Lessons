// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int m = 3;
int n = 3;
int[,] array = new int[m, n];

SummEltmensArray(FillArray(array));

int[,] FillArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 11);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine("");
    }
    return arr;
}

void SummEltmensArray(int[,] ar)
{
    int summ = 0;
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            if (i == j)
            {
                summ += ar[i, j];
            }

        }

    }
    Console.Write($"Сумма элементов по главной диагонали равна {summ} ");

    Console.WriteLine("");
}
