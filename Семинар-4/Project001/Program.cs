//  Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.WriteLine(summ (7));

int summ (int a){
    int temp =0;
    for (int i=1; i<=a; i++  ){
         temp= temp + i; 
    }return temp;
} 


