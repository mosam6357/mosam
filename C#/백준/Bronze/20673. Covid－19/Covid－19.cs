using System;

namespace q{
    class w{
        static void Main(){
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            if(a<=50 && b<=10){
                Console.WriteLine("White");
            }
            else if(b>30){
                Console.WriteLine("Red");
            }
            else{
                Console.WriteLine("Yellow");
            }
        }
    }
}