using System;
using System.Linq; 
using System.Collections.Generic; 
namespace list{
    class sortList{
        static void Main(){
            List<string> arr = new List<string>() {"Srushti", "Aditi","Rutuja"};
            var final = arr.OrderBy(n => n);
            Console.WriteLine("Sorted List is:"); 
            foreach (string data in final) 
            { 
                Console.Write(data + " "); 
            } 
        }
    }
}