// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Numbers(5);
int Numbers (int number)
{ 
     
    // int [] array = new array[num]; 
    if (number == 0) return 0; 
    Console.Write((number)+ " "); 
 
    return Numbers(number-1); 
} 
 
