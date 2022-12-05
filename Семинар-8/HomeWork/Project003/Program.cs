
// адача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int m = 2;
int n = 2;
// int[,] array = new int[m, n];
// int[,] array1 = new int[m, n];
int[,] array = {{2,4} , {3, 2}};
int[,] array1 = {{3,4} , {3, 3}};
int [,] workArrays = new int[m, n];
PrinArray(array);
PrinArray(array1);

PrinArray(WorkMatrix(array, array1,workArrays));

int[,] WorkMatrix(int[,] matrixOne,int[,] matrixTwo,int[,] workMatrix)
{
    for (int i = 0; i <matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixOne.GetLength(1); j++)
        {
            workMatrix[i,j] = 0;
            for (int k = 0; k <matrixOne.GetLength(1); k++)
//                 resultMatrix[i,j] += op1[i,k] * op2[k,j];
           workMatrix[i,j] += matrixOne[i,k]*matrixTwo[k,j];
        }

    }
    return workMatrix;
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
