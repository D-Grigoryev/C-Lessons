﻿//Игра Крестики - нолики. Автор: Григорьев Д.Ю. email - dinvest4@gmail.com


char cross = 'X'; 
char zero = 'O';

int fieldSize = 3;

int gameMode=0;

char [ , ] field = new char [fieldSize,fieldSize];
char[] numbers = {'1','2','3','4','5','6','7','8','9'};

Console.Clear();
Console.WriteLine("Выберите режим игры 0 - игра с человека, 1 - игра с компьютером");
Console.Write("Введите значение - ");
gameMode=Convert.ToInt32(Console.ReadLine());
InitField();
PrintField();

while(true){
    if(gameMode==0){
        if (!CheckGameEnd()){
        HumanTurnCross();
        }else break;
         if (!CheckGameEnd()){
        HumanTurnZero();
        }else break;
         
    }
    else if (gameMode==1){
       if (!CheckGameEnd()){
        HumanTurnCross();
        }else break;
         if (!CheckGameEnd()){
         СomputerTurn ();
        }else break;
    }
}

void InitField (){
    int count=0;
    for (int x=0; x<fieldSize;x++){
        for (int y=0;y<fieldSize;y++){
           field[x,y]=numbers[count];
           count++;
        }
    }
}

void PrintField (){
    Console.Clear();
    for (int i = 0; i <= fieldSize; i++) {
        Console.Write("+" + "  ");
    }
    Console.WriteLine();
    Console.WriteLine();
    for (int i = 0; i < fieldSize; i++) {
        Console.Write(("+") + "  ");
            for (int j = 0; j < fieldSize; j++) {
                Console.Write(field[i,j] + "  ");
            }
       Console.WriteLine();
       Console.WriteLine();
    }
    Console.WriteLine();
}

void HumanTurnCross (){
Console.WriteLine("Ход крестиков");
Console.Write("Введите номер клетки - ");
char userTurn = Convert.ToChar(Console.ReadLine());
bool validNumber = false;
Console.WriteLine(userTurn);
        if (Validator(userTurn)){
        for (int x=0; x<fieldSize;x++){
            for (int y=0;y<fieldSize;y++){
                if (field[x,y].Equals(userTurn)){
                    field[x,y]=cross;
                    validNumber=true;
                    break;                  
                } 
            }
         }if (validNumber==false){
            Console.WriteLine("Вы ввели не верное значение, попробуйте снова");
            HumanTurnCross();
         }
    }
    else {
        Console.WriteLine("Вы ввели не верное значение, попробуйте снова");
        HumanTurnCross();
    }
    PrintField();  
}

void HumanTurnZero (){
Console.WriteLine("Ход ноликов");
Console.Write("Введите номер клетки - ");
char userTurn = Convert.ToChar(Console.ReadLine());
bool validNumber = false;
Console.WriteLine(userTurn);
        if (Validator(userTurn)){
        for (int x=0; x<fieldSize;x++){
            for (int y=0;y<fieldSize;y++){
                if (field[x,y].Equals(userTurn)){
                    field[x,y]=zero;
                    validNumber=true;
                    break;                  
                } 
            }
         }if (validNumber==false){
            Console.WriteLine("Вы ввели не верное значение, попробуйте снова");
            HumanTurnZero();
         }
    }
    else {
        Console.WriteLine("Вы ввели не верное значение, попробуйте снова");
        HumanTurnZero();
    }
    PrintField();
}

void СomputerTurn (){
   Console.WriteLine("Ход компьютера");
string rnd = Convert.ToString(new Random().Next(1,10));
char computerTurn = Convert.ToChar(rnd);
bool validNumber = false;
        if (Validator(computerTurn)){
        for (int x=0; x<fieldSize;x++){
            for (int y=0;y<fieldSize;y++){
                if (field[x,y].Equals(computerTurn)){
                    field[x,y]=zero;
                    validNumber=true;
                    break;                  
                }
            }
         }if (validNumber==false){
            СomputerTurn();
         }
    }
    else {
         СomputerTurn();
    }
    PrintField();   
}

bool CheckGameEnd(){  
                //проверка на ничью

         
            for (int i = 0; i < fieldSize; i++) {
            
             if (checkLine(i, 0, 0, 1, cross)) {
                 Console.WriteLine("GAME OVER - Победили Крестики");
                 return true;
             }
             if (checkLine(i, 0, 0, 1, zero)) {
                 Console.WriteLine("GAME OVER - Победили Нолики");
                 return true;
             }
             
             if (checkLine(0, i, 1, 0, cross)) {
                 Console.WriteLine("GAME OVER - Победили Крестики");
                 return true;
             }
             if (checkLine(0, i, 1, 0, zero)) {
                Console.WriteLine("GAME OVER - Победили Нолики");
                 return true;
             }
        
             if (checkLine(0, 0, 1, 1, cross)) {
                Console.WriteLine("GAME OVER - Победили Крестики");
                return true;
            }
             if (checkLine(0, 0, 1, 1, zero)) {
                Console.WriteLine("GAME OVER - Победили Нолики");
                return true;
            }
             if (checkLine(0, fieldSize - 1, 1, -1, cross)) {
                Console.WriteLine("GAME OVER - Победили Крестики");
                return true;
            }
             if (checkLine(0, fieldSize - 1, 1, -1, zero)) {
                Console.WriteLine("GAME OVER - Победили Нолики");
                return true;
         }
           
         }
                if (!checkDrow(field)){
                Console.WriteLine("GAME OVER - Ничья");
                return true;
            }
         return false;
     }

bool checkLine(int start_x, int start_y, int dx, int dy, char sign) {
         for (int i = 0; i < fieldSize; i++) {
             if (field[start_x + i * dx, start_y + i * dy] != sign)
                 return false;
         }
         return true;
     }

bool checkDrow(char [ , ] arr){
            foreach (char c in arr){    
                    if (!c.Equals(cross)  ){
                        if (!c.Equals(zero)){
                            return true;
                        }
                } 
        }
                 return false;
    }
        
bool Validator (char str){
    foreach (char c in numbers){
        if (c.Equals(str)){
            return true; 
        }
    }
            return false;
}
    



       
    
   


 