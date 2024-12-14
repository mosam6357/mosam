using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i=0; i<a; i++){
                int b = int.Parse(Console.ReadLine());
                if(b<=3){
                    int[] aa = {0,1,2,4};
                    Console.WriteLine(aa[b]);
                }
                else{
                    int[] aa = new int[b+1];
                    aa[0]=0;aa[1]=1;aa[2]=2;aa[3]=4;
                    for(int j=4;j<b+1;j++){
                        aa[j]=aa[j-1]+aa[j-2]+aa[j-3];
                    }
                    Console.WriteLine(aa[b]);
                }
            }
        }
    }
}