using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = new int[5];
            int time = 0;
            for (int i=0; i<5; i++){
                aa[i] = int.Parse(Console.ReadLine());
            }
            while(aa[0]<aa[1]){
                if(aa[0]<0){
                    time+=aa[2];
                    aa[0]++;
                }
                else if(aa[0]==0){
                    time+=aa[3]+aa[4];
                    aa[0]++;
                }
                else{
                    time+=aa[4];
                    aa[0]++;
                }
            }
            Console.WriteLine(time);
        }
    }
}