using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<a;i++){
                int n = int.Parse(Console.ReadLine());
                int cnt = 0;
                for (int j=1;j<n+1;j++){
                    if(n%j==0){cnt++;}
                }
                Console.WriteLine($"{n} {cnt}");
            }
        }
    }
}