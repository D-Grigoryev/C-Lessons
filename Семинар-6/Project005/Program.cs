// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования.

printArr(copyArray(creatArray(5)));

int [] copyArray(int [] arr){
Console.Write("Копируем массив: ");
    int [] copyArray = new int [arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArray[i] = arr[i];
    }return copyArray;
}

int [] creatArray (int size){
   Console.Write("Создаем массив: ");
   int [] array = new int [size];
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(1, 10);
    }printArr(array);
    return array;
}

void printArr(int[] arr){
    foreach(int a in arr){
        Console.Write(a + " ");
    }Console.WriteLine("");
}