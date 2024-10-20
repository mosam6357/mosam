using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = new int[10];
            for (int i =0; i<5; i++){
                aa[int.Parse(Console.ReadLine())]++;
            }
            for (int i =0; i<10; i++){
                if(aa[i]%2!=0){
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}