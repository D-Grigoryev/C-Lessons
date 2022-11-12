// Напиште программу, которая принимает на вход число и выдает его квадарт (число)
Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
math(num);
void math (int x)
{
    Console.WriteLine("Квадрат числа x равен: "+x*x);
}