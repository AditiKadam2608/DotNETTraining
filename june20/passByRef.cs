using System;
namespace pass{
    class passByRef{
        public static void swapp(ref int a, ref int b){
            int temp;
            temp = a;
            a=b;
            b = temp;
        }

    static void Main(){
        int a = 5;
        int b = 6;
        Console.WriteLine("Before Swapping");
        Console.WriteLine("A=", +a);
        Console.WriteLine("b=", +b);
        swapp(ref a, ref b);
        Console.WriteLine("After Swapping");
        Console.WriteLine("A=",+ a);
        Console.WriteLine("b=", +b);
    }
    }
}