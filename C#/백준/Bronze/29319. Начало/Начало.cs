using System;
using System.Linq;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            Console.WriteLine(aa.Sum()-aa.Max());
        }
    }
}