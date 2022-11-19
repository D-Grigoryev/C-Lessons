
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//
//РЕШЕНИЕ ЧЕРЕЗ String

// Console.Write("Введите число: ");
// string number = Console.ReadLine();

// void CheckingNumber(string number)
// {
//   if (number[0]==number[4] || number[1]==number[3])
//   {
//     Console.WriteLine($"Число: {number} - палиндром.");
//   }
//   else Console.WriteLine($"Число: {number} - НЕ палиндром.");
// }
// if (number!.Length == 5)
// {
//   CheckingNumber(number);
// }
// else Console.WriteLine($"Введи правильное число");


//РЕШЕНИЕ БЕЗ STRING

Console.Write("Введите число: ");
double num = Convert.ToInt32(Console.ReadLine());
        
       

 Palindrom(num);
void Palindrom(double n){
    double num_length = Math.Floor(Math.Log10(num))+1;
    double first_num = Math.Floor(num/(Math.Pow(10, 4)));
    double second_num = Math.Floor((num/(Math.Pow(10, 3))%10));
    double fourth_num = Math.Floor((num%100)/10);
    double fifth_num = Math.Floor(num%10);
    if (first_num==fifth_num&&second_num==fourth_num){
        Console.WriteLine($"{num} - полниндром");
    }else{
        Console.WriteLine($"{num} - не полниндром");
    }
}
