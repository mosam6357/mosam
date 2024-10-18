using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int b = 0;
            if(a<100){
                b = 1;
            }
            if(a>100){
                b = -1;
            }
            Console.WriteLine($"{5*a-400} {b}");
        }
    }
}