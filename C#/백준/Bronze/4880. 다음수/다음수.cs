using System;
using System.Linq;

namespace q{
    class w{
        static void Main(String[] args){
            while(true){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                if (aa.Min()==aa.Max() && aa.Min()==0){
                    break;
                }
                if (aa[2]-aa[1]==aa[1]-aa[0]){
                    Console.WriteLine($"AP {aa[2]+(aa[1]-aa[0])}");
                }
                else{
                    Console.WriteLine($"GP {aa[2]*(aa[1]/aa[0])}");
                }
            }
        }
    }
}