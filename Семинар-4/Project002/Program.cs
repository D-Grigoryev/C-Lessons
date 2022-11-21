// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите значение");
string num  = Console.ReadLine();
Console.WriteLine($"Количество цифр в чисое - {summ (num)}");


int array (string num){
    int x = 0;
    x = num.Length;
    return x;
    }

