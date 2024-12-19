using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int cnt=0;
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            for (int i=0; i<5; i++){
                if(aa[i]==a){
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}