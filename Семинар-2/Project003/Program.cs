// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int x =0;
if (x==num % 7 && x==num % 23) 

Console.Write("Да");

else Console.Write("Нет");