using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int cnt = 0;
            Array.Sort(aa);
            for (int i=1; i<a; i++){
                if(aa[i]==aa[i-1]){
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}