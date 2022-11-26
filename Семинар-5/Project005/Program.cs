// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
// последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int [] array = new int [11];

void prodPairs(int [] array){
    for(int i = 0; i< array.Length; i++){
        array[i] = i+1;
    }
    int [] new_array = new int [array.Length/2];
    for (int i = 0; i < array.Length/2; i++){
        int prod = array[i]*array[array.Length-i-1];
        new_array[i] = prod;
        Console.WriteLine(new_array[i]);
    }
}

prodPairs(array);