char cross = 'X';
char zero = 'O';
char empty = '+';
int fieldSize = 3;

char [ , ] field = new char [fieldSize,fieldSize];
InitField();
PrintField();


while(!CheckGameEnd()){
HumanTurnCross();
HumanTurnZero();
}

void InitField (){
    for (int x=0; x<fieldSize;x++){
        for (int y=0;y<fieldSize;y++){
           field[x,y]=empty;
        }
    }
}
void PrintField (){
    for (int i = 0; i <= fieldSize; i++) {
        Console.Write(i + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < fieldSize; i++) {
        Console.Write((i + 1) + " ");
            for (int j = 0; j < fieldSize; j++) {
                Console.Write(field[i,j] + " ");
            }
       Console.WriteLine();
    }
    Console.WriteLine();
}
void HumanTurnCross (){
    if (!CheckGameEnd()){
Console.WriteLine("Ход крестиков");
Console.WriteLine("Введите значение строки");
int j = Convert.ToInt32(Console.ReadLine());
 if(j>fieldSize || j<=0){
    Console.WriteLine("Вы ввели неверное значение, попробуйте снова");
     HumanTurnCross();
  }   
Console.WriteLine("Введите значение столбца");
int e = Convert.ToInt32(Console.ReadLine());
    if(e>fieldSize || e<=0){
    Console.WriteLine("Вы ввели неверное значение, попробуйте снова");
     HumanTurnCross();
  }   
    if (field[j-1,e-1].Equals(empty)){
    field[j-1,e-1]=cross;
        }
    else {
        Console.WriteLine("Эта клетка занята, выберите другую");
        HumanTurnCross();
        }
    
    PrintField();   
    }else Console.Write("");
}

void HumanTurnZero (){
    if(!CheckGameEnd()){
Console.WriteLine("Ход ноликов");
Console.WriteLine("Введите значение строки");
int j = Convert.ToInt32(Console.ReadLine());
if(j>fieldSize || j<=0){
    Console.WriteLine("Вы ввели неверное значение, попробуйте снова");
     HumanTurnZero();
  }

Console.WriteLine("Введите значение столбца");
int e = Convert.ToInt32(Console.ReadLine());
  if(e>fieldSize || e<=0){
    Console.WriteLine("Вы ввели неверное значение, попробуйте снова");
     HumanTurnZero();
  }
  if (field[j-1,e-1].Equals(empty)){
        field[j-1,e-1]=zero;
        }
    else {
        Console.WriteLine("Эта клетка занята, выберите другую");
        HumanTurnZero();
        }
    PrintField();
    }else Console.Write("");

}

bool CheckGameEnd(){
           bool isEmpty=true;
            for (int x=0; x<fieldSize;x++){
              for (int y=0;y<fieldSize; y++){
                 if(field[x,y].Equals(empty)){
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
    
       
    
   


