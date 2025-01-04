using System;
using System.Linq;

namespace q{
    class w{
        static void Main(){
            while(true){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int a = aa[0];
                int b = aa[1];
                if (a==b && a==0){
                    break;
                }
                int[] bb = new int[3];
                bb[0] = a*40+b*20;
                bb[1] = a*35+b*30;
                bb[2] = a*30+b*40;
                Console.WriteLine(bb.Min());
            }
        }
    }
}