// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] arr = new int [12]; 
creatArray(arr);
Console.WriteLine(" ");
colEven (arr);

void colEven (int [] array){
    int count=0;
foreach(int ar in array){
    if ((ar & 1) ==0){
        count++;
    }
    }
   Console.WriteLine($"Количество положительных чисел {count}");
}
 
void creatArray (int [] array){
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
}