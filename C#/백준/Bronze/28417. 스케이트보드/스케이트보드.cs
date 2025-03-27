using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int max = 0;
            for (int i=0;i<a;i++){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int score = Math.Max(aa[0],aa[1]);
                aa[0]=-1; aa[1]=-1;
                Array.Sort(aa);
                score+=aa[6]+aa[5];
                max = max>score?max:score;
            }
            Console.WriteLine(max);
        }
    }
}