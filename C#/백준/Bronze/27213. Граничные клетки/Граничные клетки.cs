using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if(a>2 && b>2){
                Console.WriteLine(a*b-(a-2)*(b-2));
            }
            else{
                Console.WriteLine(a*b);
            }
        }
    }
}