using System;
using System.Linq;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            long total = 0;
            for (int i=0;i<a;i++){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                total+=aa.Sum();
            }
            Console.WriteLine(total);
        }
    }
}