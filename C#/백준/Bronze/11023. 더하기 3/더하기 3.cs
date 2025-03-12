using System;
using System.Linq;

namespace q{
    class w{
        static void Main(String[] args){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            Console.WriteLine(aa.Sum());
        }
    }
}