using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int c1 = aa[0]%aa[1]==0?aa[0]/aa[1]*aa[2]:(aa[0]/aa[1]+1)*aa[2];
            int c2 = aa[0]%aa[3]==0?aa[0]/aa[3]*aa[4]:(aa[0]/aa[3]+1)*aa[4];
            Console.WriteLine(c1<c2?c1:c2);
        }
    }
}