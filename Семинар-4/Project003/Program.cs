// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120
Console.WriteLine(multi (7));

int multi (int a){
    int temp =1;
    for (int i=1; i<=a; i++  ){
         temp= temp * i; 
    }return temp;
} 
