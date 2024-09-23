using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine()); int sum=0;
            int b = (a*(a+1))/2;
            Console.WriteLine(b);
            Console.WriteLine(b*b);
            for (int i =1; i<a+1; i++){
                sum+=i*i*i;
            }
            Console.WriteLine(sum);
        }
    }
}