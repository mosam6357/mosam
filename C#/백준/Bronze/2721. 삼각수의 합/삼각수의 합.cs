using System;

namespace q{
    class w{
        static void Main(){
            int t = int.Parse(Console.ReadLine());
            for (int i=0;i<t;i++){
                int a = int.Parse(Console.ReadLine());
                int total = 0;
                for (int j=1;j<=a+1;j++){
                    total+=(j-1)*j*(j+1)/2;
                }
                Console.WriteLine(total);
            }
        }
    }
}