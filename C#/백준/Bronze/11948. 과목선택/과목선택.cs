using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = new int[4];
            int[] bb = new int[2];
            for(int i =0; i<6; i++){
                if(i<4){
                    aa[i] = int.Parse(Console.ReadLine());
                }
                else{
                    bb[i-4] = int.Parse(Console.ReadLine());
                }
            }
            int min1 = 100;
            for (int i =0; i<4; i++){
                if(aa[i]<min1){
                    min1 = aa[i];
                }
            }
            int min2 = bb[0]<bb[1]?bb[0]:bb[1];
            Console.WriteLine(aa.Sum()+bb.Sum()-(min1+min2));
        }
    }
}