/*Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/

int[] CreateArray(int length)
{
    int[] numbers = new int[length];
    for (int n = 0; n < numbers.Length; n++)
    {
        numbers[n] = new Random().Next(0, 100);
        Console.Write(numbers[n] + " ");
    }
    Console.WriteLine();
    return numbers;
}
int length = 10;
int[] oldArray = CreateArray(length);

int[] ReverseArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[array.Length - 1 - i];
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}
ReverseArray(oldArray);