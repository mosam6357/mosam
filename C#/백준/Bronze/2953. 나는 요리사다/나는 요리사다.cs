using System;
using System.Linq;

namespace q{
    class w{
        static void Main(){
            int max = 0;
            int n = 0;
            for (int i =0;i<5;i++){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                n = max>aa.Sum()?n:i+1;
                max = max>aa.Sum()?max:aa.Sum();
                
            }
            Console.WriteLine($"{n} {max}");
        }
    }
}