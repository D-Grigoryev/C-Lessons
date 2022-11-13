int Max (int a, int b, int c){
    int result = a;
    if(b>result) result=b;
    if(c>result) result=c;
    return result;

}
int a1=19;
int b1=20;
int c1=21;

int a2=52;
int b2=30;
int c2=31;

int a3=39;
int b3=40;
int c3=41;

int max1 = Max(a1,b1,c1);
int max2 = Max(a2,b2,c2); 
int max3 = Max(a3,b3,c3);
int maxFinal = Max(max1,max2,max3); 

int max = Max (Max(a1,b1,c1), Max(a2,b2,c2), Max(a3,b3,c3));

Console.WriteLine ("max1= "+max1);
Console.WriteLine ("max2= "+max2);
Console.WriteLine ("max3= "+max3);
Console.WriteLine ("maxFinal= "+maxFinal);
Console.WriteLine ("max= "+max);
