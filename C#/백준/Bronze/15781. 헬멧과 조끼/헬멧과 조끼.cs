using System;
using System.Linq;

namespace q{
    class w{
        static void Main(String[] args){
            string a = Console.ReadLine();
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            Console.WriteLine(aa.Max()+bb.Max());
        }
    }
}