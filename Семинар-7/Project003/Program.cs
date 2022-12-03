// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int m = 3;
int n = 4;
int[,] array = new int[m, n];

ChangeEltmensArray(FillArray(array));

int[,] FillArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i+j;
            Console.Write($"{arr[i, j]} ");
        }
       Console.WriteLine("");
    }
    return arr;
}

void ChangeEltmensArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0){
                ar[i,j] =  Convert.ToInt32(Math.Pow(ar[i,j],2));
            }
            Console.Write($"{ar[i, j]} ");

        }
        Console.WriteLine("");
    }
}