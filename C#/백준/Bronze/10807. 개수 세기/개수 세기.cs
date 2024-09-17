using System;

namespace q{
    class w{
        static void Main(){
            int a= int.Parse(Console.ReadLine());
            String[] aa = Console.ReadLine().Split();
            int[] aaa = Array.ConvertAll(aa, int.Parse);
            int b = int.Parse(Console.ReadLine()); int cnt=0;
            foreach(int d in aaa){
                if(b==d){
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}