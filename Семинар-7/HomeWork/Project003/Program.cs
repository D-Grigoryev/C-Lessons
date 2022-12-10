// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = 3;
int n = 4;
int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
PrintAvgArray(Average(array));

void FillArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);


        }
    }
}
void PrintArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            Console.Write($"{ar[i, j],1} ");

        }
        Console.WriteLine("");
    }
}
double[] Average(int[,] ar)
{
    double[] avg = new double[ar.GetLength(1)];
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            avg[j] += Convert.ToDouble(ar[i, j]);
        }
    }
    for (int k = 0; k < avg.Length; k++)
    {
        avg[k] /= ar.GetLength(0);
       
    }
    return avg;
}

void PrintAvgArray(double[] avgArray)
{
    for (int i = 0; i < avgArray.Length; i++)
    {
        Console.WriteLine($"Среднеарифмитическое столбца №{i + 1} равно {avgArray[i]}");
    }
}