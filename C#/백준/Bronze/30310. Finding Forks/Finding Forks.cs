using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            Array.Sort(aa);
            Console.WriteLine(aa[0]+aa[1]);
        }
    }
}