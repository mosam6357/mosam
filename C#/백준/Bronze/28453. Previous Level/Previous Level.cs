using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            string[] aaa = Console.ReadLine().Split();
            int[] aa = Array.ConvertAll(aaa,int.Parse);
            for(int i=0; i<a; i++){
                if(aa[i]<250){
                    Console.Write("4 ");
                }
                else{
                    Console.Write($"{13-aa[i]/25} ");
                }
            }
        }
    }
}