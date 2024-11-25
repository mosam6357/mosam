using System;

namespace q{
    class w{
        static void Main(){
            long a = long.Parse(Console.ReadLine());
            if(a%7==0 || a%7==2){
                Console.WriteLine("CY");
            }
            else{
                Console.WriteLine("SK");
            }
        }
    }
}