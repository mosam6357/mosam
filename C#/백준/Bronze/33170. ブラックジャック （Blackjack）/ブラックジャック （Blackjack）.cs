using System;
using System.Linq;

namespace q{
    class w{
        static void Main(){
            int[] aa = new int[3];
            for (int i=0;i<3;i++){
                aa[i] = int.Parse(Console.ReadLine());
            }
            if(aa.Sum()<=21){
                Console.WriteLine(1);
            }
            else{
                Console.WriteLine(0);
            }
        }
    }
}