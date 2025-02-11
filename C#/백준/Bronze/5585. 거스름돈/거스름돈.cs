using System;

namespace q{
    class w{
        static void Main(){
            int a = 1000-int.Parse(Console.ReadLine());
            Console.WriteLine(a/500+(a%500)/100+(a%100)/50+(a%50)/10+(a%10)/5+a%5);
        }
    }
}