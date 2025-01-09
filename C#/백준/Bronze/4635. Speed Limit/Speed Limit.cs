using System;

namespace q{
    class w{
        static void Main(){
            while(true){
                int a = int.Parse(Console.ReadLine());
                if (a==-1){
                    break;
                }
                int s = 0;
                int ans = 0;
                for (int i=0;i<a;i++){
                    int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                    ans += aa[0]*(aa[1]-s);
                    s+=(aa[1]-s);
                }
                Console.WriteLine($"{ans} miles");
            }
        }
    }
}