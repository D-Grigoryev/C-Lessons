// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.WriteLine("Введите число: "); 
int x = Convert.ToInt16(Console.ReadLine()); 
 
int Count(int y) 
{ 
    int count = 0; 
    while (y > 0) 
    { 
        count++; 
        y /= 2; 
    } 
    Console.WriteLine($"{count}"); 
    return count; 
} 
 
int[] array = new int[Count(x)]; 
 
string BinNum(int x, int[] array) 
{ 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (x > 0) 
        { 
            array[i] = x % 2; 
            x /= 2; 
            Console.Write($"{array[i]}"); 
        } 
    } 
    Console.WriteLine(); 
    string num = String.Empty; 
    for (int j = array.Length - 1; j >= 0; j--) 
    { 
        num += array[j]; 
    } 
    return num; 
} 

string number = new string(BinNum(x, array)); 
Console.WriteLine($"Число {x} в двоичной системе равно {number}");