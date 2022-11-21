
    int [] ar = new int [8];
    arr(ar);

    void arr (int [] arr ){
    for (int i=0; i<arr.Length; i++){
        arr[i]= new Random().Next(0,2);
        Console.Write("["+arr[i]+"] ");    
    }
    }