// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int m = 3;
int n = 4;
int[,] array = new int[m, n];
Console.WriteLine("Введите значение элемента массива");
int userNumber = Convert.ToInt32(Console.ReadLine());
FillArray(array);
PrinArray(array);
    
FindeEltmentArray(array, userNumber);

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
void PrinArray(int[,] ar)
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
void FindeEltmentArray(int[,] ar, int element)
{ int find=0;
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            if (element==array[i,j]) {
            Console.WriteLine($"Значение {element} находится в массиве по координатам {i} {j} ");   
            find++;  
        }

    } 
} if (find==0) Console.WriteLine($"Значения {element} в массиве нет ");
}