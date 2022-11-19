    // Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
    // причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

    Console.WriteLine ("Введите значение X ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Введите значение Y ");
    int y = Convert.ToInt32(Console.ReadLine());

    validEnter(x,y);
    void validEnter (int x, int y){

    if (x!= 0 && y!=0){
    cor(x,y);
    }else Console.WriteLine ("Вы ввели неккоректное значение");
    }

    void cor (int x, int y){
    if (x>0 && y>0){
        Console.WriteLine ("Четверть-1");
    }
    if (x>0 && y<0){
        Console.WriteLine ("Четверть-2");
    }
    if (x<0&& y<0){
        Console.WriteLine ("Четверть-3");
    }
    if (x<0&& y>0){
        Console.WriteLine ("Четверть-4");
    }

    }