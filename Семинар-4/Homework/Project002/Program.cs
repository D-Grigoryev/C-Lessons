// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Console.Write("Введите число: ");
// string num = Console.ReadLine();
// Console.WriteLine(summ (num));


// РЕШЕНИЕ С ИСПОЛЬЗОВАНИЕМ String
// int summ (string a){
//     int result=0;
//     foreach(char s in a){
//         result+= (s - '0');
//     }return result;
//     }

// РЕШЕНИЕ С БЕЗ ИСПОЛЬЗОВАНИЯ String

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел {number} равна {FindThirdNumber(number)}");

int FindThirdNumber(int num)
{
    int result = 0;
    while (num > 9)
    {
        result += num % 10;
        num = num / 10;
    }
    if (num < 9)
    {
        result += num;
    }
    return result;
}
