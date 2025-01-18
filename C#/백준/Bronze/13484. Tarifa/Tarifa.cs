using System;

namespace q{
    class w{
        static void Main(){
            int lim = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;
            for (int i=0;i<n;i++){
                cnt += int.Parse(Console.ReadLine());
            }
            Console.WriteLine((n+1)*lim-cnt);
        }
    }
}