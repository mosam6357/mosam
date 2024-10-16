using System;

namespace q{
    class w{
        static void Main(){
            int sum=0;
            for (int i =0; i<10; i++){
                sum+=int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum/2);
        }
    }
}