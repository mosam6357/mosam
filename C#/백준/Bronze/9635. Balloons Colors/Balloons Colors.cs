using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<a;i++){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int n = aa[0];
                if (bb[0]==aa[1] && bb[n-1]==aa[2]){Console.WriteLine("BOTH");}
                if (bb[0]==aa[1] && bb[n-1]!=aa[2]){Console.WriteLine("EASY");}
                if (bb[0]!=aa[1] && bb[n-1]==aa[2]){Console.WriteLine("HARD");}
                if (bb[0]!=aa[1] && bb[n-1]!=aa[2]){Console.WriteLine("OKAY");}
            }
        }
    }
}