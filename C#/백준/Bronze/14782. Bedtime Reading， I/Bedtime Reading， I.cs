using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int[] aa = new int[a];
            int sum = 0;
            for (int i=1;i<a+1;i++){
                if (a%i==0){
                    sum+=i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}