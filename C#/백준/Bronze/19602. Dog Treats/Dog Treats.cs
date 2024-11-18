using System;

namespace q{
    class w{
        static void Main(){
            int a = 0;
            for (int i=1; i<4; i++){
                a+=int.Parse(Console.ReadLine())*i;
            }
            Console.WriteLine((a>=10)?"happy":"sad");
        }
    }
}