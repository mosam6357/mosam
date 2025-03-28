using System;
using System.Linq;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int[] aa = new int[a];
            for (int i=0;i<a;i++){
                aa[i] = int.Parse(Console.ReadLine());
            }
            if (aa[0]==aa.Max()){
                Console.WriteLine("S");
            }
            else{
                Console.WriteLine("N");
            }
        }
    }
}