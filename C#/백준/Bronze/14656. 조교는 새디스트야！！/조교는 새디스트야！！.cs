using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int cnt = 0;
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            for (int i=0;i<a;i++){
                if(i+1!=aa[i])
                    cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}