using System;

namespace q{
    class w{
        static void Main(){
            string[] aa = Console.ReadLine().Split();
            int sum1=0; long sum=0;
            for (int i =0; i<aa[0].Length; i++){
                sum1+=(int)aa[0][i]-'0';
            }
            for(int i=0; i<aa[1].Length; i++){
                sum+=sum1*((int)aa[1][i]-'0');
            }
            Console.WriteLine(sum);
        }
    }
}