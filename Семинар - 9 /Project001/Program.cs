// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
Console.WriteLine("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
int Numbers(int first, int end)
{
    
    // int [] array = new array[num];
    if (first > end) return 0;
    Console.Write((first)+ " ");

    return Numbers(first+1, end);
}

Numbers(1, m);

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int m = 1;
int n = 5;

int Numbers (int x, int y){
    if (x <=0 && y <=0) return 0;
    else if (x<0)
    Console.Write ()
}


// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8