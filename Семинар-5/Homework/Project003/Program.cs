// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] arr = new double[5];
creatArray(arr);
Console.WriteLine(" ");
Console.WriteLine(diff(arr));

double diff(double[] array)
{
    double min=array[0];
    double max=array[0];
   
    foreach (double ar in array)
    {
        if (ar > max)
        {
            max = ar;
        }
        if (ar < min)
        {
            min = ar;
        }
    }

    return max - min;
}

void creatArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 99);
        Console.Write($"{array[i]} ");
    }
}