// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int [] arr = new int [12]; 
creatArray(arr);
summ (arr);

void summ (int [] array){
int minusSumm=0;
int plusSumm=0;
foreach(int ar in array){
    if (ar < 0){
minusSumm += ar;
    }else{
        plusSumm+=ar;
    }
   
}
 Console.WriteLine($" сумма отрицательных чисел {minusSumm}");
Console.WriteLine($" сумма положительных чисел {plusSumm}");
}

void creatArray (int [] array){
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(-9, 10);
    }
}