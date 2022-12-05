yToChange.GetLength(0),arrayToChange.GetLength(1)];
try{
    for (int i = 0; i<arrayToChange.GetLength(0); i++){
        for (int j = 0; j<arrayToChange.GetLength(1); j++){
            tempArray[i,j] = Convert.ToString(arrayToChange[j,i]);
        }}}
        catch(Exception){
            tempArray[0,0] = "Операция невозможна!";
    }
    return tempArray;
}

string [,] array = new string [AskUser(),AskUser()];
FillArray(array);
PrintArray(array);
PrintArray(ChangeColumnsWithRows(array));