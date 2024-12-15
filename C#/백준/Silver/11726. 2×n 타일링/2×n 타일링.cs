using System;

namespace q{
    class w{
        static void Main(){
            int b = int.Parse(Console.ReadLine());
            if(b<4){
                    Console.WriteLine(b);
                }
            else{
                    long[] aa = new long[b+1];
                    aa[0]=0;aa[1]=1;aa[2]=2;aa[3]=3;
                    for(int j=4;j<b+1;j++){
                        aa[j]=(aa[j-1]+aa[j-2])%10007;
                    }
                    Console.WriteLine(aa[b]);
                }
                
            }
        }
    }