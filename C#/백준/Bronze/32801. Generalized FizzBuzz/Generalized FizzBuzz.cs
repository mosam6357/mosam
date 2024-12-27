using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int cnt1=0,cnt2=0,cnt3=0;
            for (int i=1; i<aa[0]+1; i++){
                if(i%aa[1]==0 && i%aa[2]==0){cnt3++;}
                else if(i%aa[1]==0){cnt1++;}
                else if(i%aa[2]==0){cnt2++;}
            }
            Console.WriteLine($"{cnt1} {cnt2} {cnt3}");
        }
    }
}