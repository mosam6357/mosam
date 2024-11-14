using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            a += int.Parse(Console.ReadLine())*7;
            if(a>30){
                Console.WriteLine(0);
            }
            else{
                Console.WriteLine(1);
            }
        }
    }
}