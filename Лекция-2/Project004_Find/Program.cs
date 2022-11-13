int[] array = {1,2,3,4,5,6,7,8,9,10};
int n = array.Length;

int find=7;
int index=0;

while(index<n){

    if(find==array[index]){
        Console.WriteLine(index);
        break;
    }
    index++;
}