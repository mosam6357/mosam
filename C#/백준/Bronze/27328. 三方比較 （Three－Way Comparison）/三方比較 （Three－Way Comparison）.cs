using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if(a>b){
                Console.WriteLine(1);
            }
            else if(a==b){
                Console.WriteLine(0);
            }
            else{
                Console.WriteLine(-1);
            }
        }
    }
}