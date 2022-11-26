//  Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, 
// и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2] 


int [] arr = new int [12]; 
creatArray(arr);
Console.WriteLine(" ");
swapElements (arr);

void swapElements (int [] array){
for (int i = 0; i < array.Length; i++){
    if (array[i] != 0){
        array[i]=-1*array[i];

    }
   Console.Write(array[i]+" ");
}
}
void creatArray (int [] array){
    for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(-9, 9);
        Console.Write(array[i]+" ");
    }
}
// int [] array = new int [AskUser()];

// for (int i = 0; i<array.Length; i++) array[i] = AskUser2();

// foreach(int element in array){
//     if (element !=0) element = -1*element;
// }
// Console.WriteLine(array);
// int AskUser()
// {
// Console.Write("Введите число: ");
// string? Ask = Console.ReadLine();
// if (Ask != null){
// try
// {
//     int op = int.Parse(Ask);
//     if (op>0) return op;
//     else {
//         Console.WriteLine("Введите число > 0!");
//         return AskUser();
//     };
// }
// catch (Exception)
// {
//     Console.WriteLine("Введите верное число!");
//     return AskUser();
// }
// }
// else{
//     Console.WriteLine("Введите верное число!");
//     return AskUser();
// }
// }

// int AskUser2()
// {
// Console.Write("Введите число: ");
// string? Ask = Console.ReadLine();
// if (Ask != null){
// try
// {
//     int op = int.Parse(Ask);
//     return op;
// }
// catch (Exception)
// {
//     Console.WriteLine("Введите верное число!");
//     return AskUser2();
// }
// }
// else{
//     Console.WriteLine("Введите верное число!");
//     return AskUser2();
// }

// }

