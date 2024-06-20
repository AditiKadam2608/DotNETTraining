using System;
namespace pass{
    class passByValue{
        public static void add(int a, int b){
            int c = a + b;
            Console.WriteLine("Addition is:" + c);
            return;
        }
        static void Main(){
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            add(x, y);
        }
    }
}