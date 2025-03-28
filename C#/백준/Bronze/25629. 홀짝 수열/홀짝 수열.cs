using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int cnt = 0;
            for (int i=0;i<a;i++){
                int n = aa[i]%2;
                if (n==1){
                    cnt++;
                }
                else{
                    cnt--;
                }
            }
            if (a%2==cnt){
                Console.WriteLine("1");
            }
            else{
                Console.WriteLine("0");
            }
        }
    }
}