using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int[] aa = new int[a];
            int cost = 0;
            for(int i =0; i<a; i++){
                aa[i]=int.Parse(Console.ReadLine());
            }
            int b = int.Parse(Console.ReadLine());
            for (int i =0; i<b; i++){
                int num=int.Parse(Console.ReadLine())-1;
                cost+=aa[num];
            }
            Console.WriteLine(cost);
        }
    }
}