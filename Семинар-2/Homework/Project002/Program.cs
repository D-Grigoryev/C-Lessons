// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void FindThirdNumber(int num){
	int result=0;
    if (num>999){
        while (num > 999){
            num = num/10;
            if (num>99 && num<999){
                result=num %10;  
            }
    }
            Console.WriteLine("Третий знак "+ num +" - "+result);
    } else if (num<100){ 
    Console.WriteLine("В этом числе нет третьего знака");
     }
    
    }
    
Console.Write("Введите число от трех знаков: ");
int number = Convert.ToInt32(Console.ReadLine());
FindThirdNumber(number);
