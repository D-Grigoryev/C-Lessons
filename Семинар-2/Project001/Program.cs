// 11. 
// Напишите программу, которая выводит случайное трехзначное 
// число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int n1=num/100;
int n3=num%10;
int n= n1*10+n3;
Console.WriteLine(n);