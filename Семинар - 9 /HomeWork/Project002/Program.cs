// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

 int summ=0;
int Numbers(int first, int end) 
{ 
    
    if (first < 0 && end < 0) 
    Console.WriteLine("Отсутствуеют натуральные числа"); 
    else if (first < 0 && end > 0) 
    return Numbers (1, end); 
    if (first > end) return 0; 
    summ+=first;
 
    return Numbers(first+1, end); 
} 
 
Numbers(4, 8);
Console.WriteLine("Сумма элементов равна "+summ);