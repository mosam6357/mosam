using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int i = 0;
            int[] aa = {0,0};
            while(a>0){
                int k = i%2;
                if (a%2==0){
                    aa[k]+=a/2;
                    a-=a/2;
                }
                else{
                    aa[k]+=a/2+1;
                    a-=a/2+1;
                }
                i++;
            }
            Console.WriteLine($"{aa[1]} {aa[0]}");
        }
    }
}