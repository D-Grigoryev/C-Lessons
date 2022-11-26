// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int [] arr = new int [12]; 
Console.WriteLine("Ввведите значение ");
int num = Convert.ToInt32(Console.ReadLine());
creatArray(arr);
findeEltment (num);

void findeEltment (int num){
foreach(int ar in arr){
   if (ar == num){
    Console.WriteLine($" Введенное знаение есть в массиве");
    break;
    }
} 
}


void creatArray (int [] array){
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(-9, 9);
        Console.Write(array[i]+" ");
    }
}