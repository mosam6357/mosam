using System;
using System.Linq;

namespace q{
    class w{
        static void Main(String[] args){
            while(true){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int a = aa[0]; int b = aa[1];
                if (a==0 && b==0){
                    break;
                }
                Console.WriteLine(2*a-b);
            }
        }
    }
}