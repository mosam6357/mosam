using System;

namespace q{
    class w{
        static void Main(){
            int sum=0;
            String[] aa = Console.ReadLine().Split();
            for(int i =0; i<6; i++){
                sum+=int.Parse(aa[i])*5;
            }
            Console.WriteLine(sum);
        }
    }
}