// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double [] array = new double[2];
findePoint(2,5,4,9,array);
printPoint(array);

void printPoint (double [] arr){
Console.Write("Линии пересекаются в точке: ");
for ( int i=0; i<array.GetLength(0); i++) {
    Console.Write(array[i]+" ");
}
}

void findePoint (double b1, double k1, double b2, double k2, double[] arr){
    if (k1 == k2 && b1 == b2) Console.WriteLine("Линии совпадают"); 
        else if (k1 == k2) Console.WriteLine("Линии не пересекаются"); 
        else 
     { 
    double x = (b2-b1)/(k1-k2);
    double y = (k1 * x) + b1;
    arr [0] = x;
    arr [1] = y;
    }
    
}
//ДРУГОЕ РЕШЕНИЕ

// Console.WriteLine("Введите значение углового коэффициента k1: "); 
// double k1 = Convert.ToInt64(Console.ReadLine()); 
// Console.WriteLine("Введите значение свободного коэффициента b1: "); 
// double b1 = Convert.ToInt64(Console.ReadLine()); 
// Console.WriteLine("Введите значение углового коэффициента k2: "); 
// double k2 = Convert.ToInt64(Console.ReadLine()); 
// Console.WriteLine("Введите значение свободного коэффициента b2: "); 
// double b2 = Convert.ToInt64(Console.ReadLine()); 
 
// void Coordinates(double k1, double b1, double k2, double b2) 
// { 
//     if (k1 == k2 && b1 == b2) Console.WriteLine("Линии совпадают"); 
//     else if (k1 == k2) Console.WriteLine("Линии не пересекаются"); 
//     else 
//     { 
//         double x = (b2 - b1) / (k1 - k2); 
//         double y = k1 * x + b1; 
//         Console.WriteLine($"Линии пересекаются в точке ({x}, {y})"); 
//     } 
// } 
// Coordinates(k1, b1, k2, b2);