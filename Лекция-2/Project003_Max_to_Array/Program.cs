int Max (int a, int b, int c){
    int result = a;
    if(b>result) result=b;
    if(c>result) result=c;
    return result;

}

int[] array = {1,2,3,4,56,6,7,8,9};


int max = Max (
Max(array[0],array[1],array[2]),
Max(array[3],array[4],array[5]),
Max(array[6],array[7],array[8]));

Console.WriteLine(max);