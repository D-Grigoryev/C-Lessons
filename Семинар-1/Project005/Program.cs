// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Ввведите число");
int num = Convert.ToInt32 (Console.ReadLine());
int num1 = -num;
for (int x=num1; x<=num; x++){
   
    Console.WriteLine(num1);
     num1++;
}