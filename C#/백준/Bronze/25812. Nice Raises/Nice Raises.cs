using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int a = aa[0]; int b = aa[1]; int cnt1 = 0; int cnt2 = 0;
            for (int i=0;i<a;i++){
                int c = int.Parse(Console.ReadLine());
                if (b>c)
                    cnt1++;
                else if(c>b)
                    cnt2++;
            }
            if (cnt1>cnt2)
                Console.WriteLine(1);
            else if (cnt2>cnt1)
                Console.WriteLine(2);
            else
                Console.WriteLine(0);
        }
    }
}