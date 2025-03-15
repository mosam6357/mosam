using System;
using System.Linq;

namespace q{
    class w{
        static void Main(String[] args){
            int t = int.Parse(Console.ReadLine());
            for (int i=0;i<t;i++){
                int a = int.Parse(Console.ReadLine());
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                Console.WriteLine($"{aa.Min()} {aa.Max()}");
            }
        }
    }
}