// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int [] arr = new int [123]; 
creatArray(arr);
 Console.WriteLine(" ");
findeEltment (arr);

void findeEltment (int [] arr){
    int count =0;
foreach(int ar in arr){
   if (ar >9&& ar<100){
    count ++;
    
    }
} Console.WriteLine($" Количество эллементов массива в диапазоне от 10 до 99 равно {count}");

}

void creatArray (int [] array){
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(0, 999);
        
    }
}