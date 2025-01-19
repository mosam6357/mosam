using System;
using System.Linq;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<a;i++){
                Console.WriteLine(Array.ConvertAll(Console.ReadLine().Split(),int.Parse).Sum());
            }
        }
    }
}