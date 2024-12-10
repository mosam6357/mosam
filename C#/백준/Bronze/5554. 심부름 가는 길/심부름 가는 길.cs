using System;

namespace q{
    class w{
        static void Main(){
            int time = 0;
            for (int i=0; i<4; i++){
                time+=int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{time/60}\n{time%60}");
        }
    }
}