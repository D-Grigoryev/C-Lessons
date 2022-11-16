//Игра Крестики - нолики. Автор: Григорьев Д.Ю. email - dinvest4@gmail.com


char cross = 'X'; 
char zero = 'O';
char empty = '+';
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


while(!CheckGameEnd()){
    if(gameMode==0){
        HumanTurnCross();
        HumanTurnZero();
    }
    else if (gameMode==1){
        HumanTurnCross();
        СomputerTurn ();
        
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
    if (!CheckGameEnd()){
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
    }else Console.Write("");
}

void HumanTurnZero (){
    if(!CheckGameEnd()){
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
    
    }else Console.Write("");

}

void СomputerTurn (){
   Console.WriteLine("Ход компьютера");
    if (!CheckGameEnd()){
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
    }else Console.Write("");
}

bool CheckGameEnd(){
           
           bool isEmpty=true;

            for (int x=0; x<fieldSize;x++){
              for (int y=0;y<fieldSize; y++){
                 if(!field[x,y].Equals(cross)|| !field[x,y].Equals(zero)){
                    isEmpty=true;
                    break;
                }else isEmpty=false;      
            }
         }
        if (isEmpty==false){
             Console.WriteLine("GAME OVER - Ничья");
            return true;
        }
    
           if(
            //Проверка диагоналей
            (field[0,0].Equals(cross)&&field[1,1].Equals(cross)&&field[2,2].Equals(cross))
            || (field[0,2].Equals(cross)&&field[1,1].Equals(cross)&&field[2,0].Equals(cross))
            //Проверка горизонталей
            || (field[0,0].Equals(cross)&&field[0,1].Equals(cross)&&field[0,2].Equals(cross))
            || (field[1,0].Equals(cross)&&field[1,1].Equals(cross)&&field[1,2].Equals(cross))
            || (field[2,0].Equals(cross)&&field[2,1].Equals(cross)&&field[2,2].Equals(cross))
            //Проверка вертикалей
            || (field[0,0].Equals(cross)&&field[1,0].Equals(cross)&&field[2,0].Equals(cross))
            || (field[0,1].Equals(cross)&&field[1,1].Equals(cross)&&field[2,1].Equals(cross))
            || (field[0,2].Equals(cross)&&field[1,2].Equals(cross)&&field[2,2].Equals(cross))
            ){
            Console.WriteLine("GAME OVER - Победили Крестики");
            return true;
        }
         if(
            //Проверка диагоналей
            (field[0,0].Equals(zero)&&field[1,1].Equals(zero)&&field[2,2].Equals(zero))
            || (field[0,2].Equals(zero)&&field[1,1].Equals(zero)&&field[2,0].Equals(zero))
            //Проверка горизонталей
            || (field[0,0].Equals(zero)&&field[0,1].Equals(zero)&&field[0,2].Equals(zero))
            || (field[1,0].Equals(zero)&&field[1,1].Equals(zero)&&field[1,2].Equals(zero))
            || (field[2,0].Equals(zero)&&field[2,1].Equals(zero)&&field[2,2].Equals(zero))
            //Проверка вертикалей
            || (field[0,0].Equals(zero)&&field[1,0].Equals(zero)&&field[2,0].Equals(zero))
            || (field[0,1].Equals(zero)&&field[1,1].Equals(zero)&&field[2,1].Equals(zero))
            || (field[0,2].Equals(zero)&&field[1,2].Equals(zero)&&field[2,2].Equals(zero))
            ){
            Console.WriteLine("GAME OVER - Победили Нолики");
            return true;
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
    



       
    
   


