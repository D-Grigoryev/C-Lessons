// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int m = new Random().Next(1,10);
Console.WriteLine ($"Введите {m} положительных и отрицательных чисел");
int [] numbers = new int [m];

Console.WriteLine(creatArray(numbers));
Console.WriteLine($"В массиве {minusSum(numbers)} отрицательных чисел");

int [] creatArray (int [] array){
    for (int i = 0; i < array.Length; i++){
        Console.WriteLine ($"Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
    }

int minusSum(int [] array){
    int count = 0;
    foreach(int a in array ){
        if (a<0) count++;
    }return count;
}

  