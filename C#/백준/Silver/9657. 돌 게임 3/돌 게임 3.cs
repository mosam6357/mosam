using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int b = a>=4?a:4;
            int[] aa = new int[b+1];
            aa[0] = 1; aa[1] = 1; aa[2] = 0; aa[3] = 1; aa[4]=1;
            for (int i=5; i<=a; i++){
                if(aa[i-1]+aa[i-3]+aa[i-4]==3){
                    aa[i] = 0;
                }
                else{
                    aa[i] = 1;
                }
            }
            if(aa[a]==1){
                Console.WriteLine("SK");
            }
            else{
                Console.WriteLine("CY");
            }
        }
    }
}