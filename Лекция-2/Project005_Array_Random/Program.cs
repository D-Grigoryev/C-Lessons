void FilArray(int[] arr){
    int index=0;
    while(index<arr.Length){
        arr[index]= new Random().Next(1,10);
        index++;
    }
}
void PrintArray(int[] arr){
    int index=0;
    while(index<arr.Length){
        Console.Write(arr[index]+" ");
        index++;
    }
}
int IndexOf (int[] arr, int find){
    int position=-1;
    int index=0;

    while(index<arr.Length){
        if (arr[index]==find){
        position=index;
        break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10];

FilArray(array);
PrintArray(array);
int pos = IndexOf(array, 5);
Console.WriteLine();
Console.WriteLine(pos);

