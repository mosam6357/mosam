using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int[] aa = {0,0,1,1,2,3,2};
            if(a<=6){
                Console.WriteLine(aa[a]);
            }
            else{
                int[] bb = new int[a+1];
                for (int i=0; i<7; i++){
                    bb[i] = aa[i];
                }
                for (int i=7; i<a+1; i++){
                    int[] cc = {1000000,1000000,1000000};
                    cc[0] = bb[i-1]+1;
                    if(i%2==0){
                        cc[1] = bb[i/2]+1;
                    }
                    if(i%3==0){
                        cc[2] = bb[i/3]+1;
                    }
                    bb[i] = cc.Min();
                }
                Console.WriteLine(bb[a]);
            }
        }
    }
}