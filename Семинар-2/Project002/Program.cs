// Напишите программу, которая будет принимать на вход два числа и выводит, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == (num2*num2))
Console.Write("Кратно");
else
Console.Write(num2 % 10);