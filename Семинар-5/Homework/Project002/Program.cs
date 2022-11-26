// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] arr = new int [4]; 
creatArray(arr);
Console.WriteLine(" ");
arraySumNumbers (arr);

void arraySumNumbers (int [] array){
    int summ=0;
for (int i=1; i < array.Length; i+=2){
    summ+= array[i];
    }
    Console.WriteLine($"Сумма элементов {summ}");
    }
   
void creatArray (int [] array){
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(1, 99);
        Console.Write($"{array[i]} ");
    }
}