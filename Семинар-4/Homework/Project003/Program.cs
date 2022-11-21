// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

printArray(arrayNumbers(creatArray(8)));


int[] creatArray(int arrayLenght)
{
    int[] ar = new int[arrayLenght];
    return ar;
}
int[] arrayNumbers(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }return arr;
}
void printArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
}