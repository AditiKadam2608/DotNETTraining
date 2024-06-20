using System;
namespace str{
    class oppCase{
        static void Main(){
            string ip = "Aditi Dinkar Kadam";
            string op = oppCase1(ip);
            Console.WriteLine("Input is :" +ip);
            Console.WriteLine("Output is :" +op);

        }

        public static string oppCase1(string str){
            char[] chars = str.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsUpper(chars[i]))
            {
                chars[i] = char.ToLower(chars[i]);
            }
            else if (char.IsLower(chars[i]))
            {
                chars[i] = char.ToUpper(chars[i]);
            }
        }
        return new string(chars);

        }
    }
}