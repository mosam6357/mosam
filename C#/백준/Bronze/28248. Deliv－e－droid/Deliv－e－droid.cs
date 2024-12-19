using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int score = a*50-b*10;
            score+=a>b?500:0;
            Console.WriteLine(score);
        }
    }
}