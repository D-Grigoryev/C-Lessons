// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double [] array = new double[2];
findePoint(2,5,4,9,array);
printPoint(array);

void printPoint (double [] arr){
for ( int i=0; i<array.GetLength(0); i++) {
    Console.WriteLine(array[i]);
}
}

void findePoint (double b1, double k1, double b2, double k2, double[] arr){
    double x = (b2-b1)/(k1-k2);
    double y = (k1 * x) + b1;
    arr [0] = x;
    arr [1] = y;
    
}