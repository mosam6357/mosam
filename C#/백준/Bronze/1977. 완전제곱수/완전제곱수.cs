using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int min = 10001;
            int sum = 0;
            for (int i=a;i<=b;i++){
                if(Math.Pow(i,0.5)%1==0){
                    sum+=i;
                    min = min<i?min:i;
                }
            }
            if (sum==0){
                Console.WriteLine(-1);
            }
            else{
                Console.WriteLine(sum);
                Console.WriteLine(min);
            }
        }
    }
}