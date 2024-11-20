using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine())+int.Parse(Console.ReadLine());
            if(a>12){
                if(a%12==0){
                    Console.WriteLine(12);
                }
                else{
                    Console.WriteLine(a%12);
                }
            }
            else{
                Console.WriteLine(a);
            }
        }
    }
}