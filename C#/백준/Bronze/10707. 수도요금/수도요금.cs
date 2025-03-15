using System;
using System.Linq;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int c1 = a*p;
            int c2 = b;
            if (p>c){
                c2+=(p-c)*d;
            }
            Console.WriteLine(Math.Min(c1,c2));
        }
    }
}