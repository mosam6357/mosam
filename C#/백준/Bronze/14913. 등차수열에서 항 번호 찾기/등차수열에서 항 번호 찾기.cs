using System;

namespace q{
    class w{
        static void Main(String[] args){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int a = aa[0]; int b = aa[1]; int c = aa[2]-a;
            if (c%b==0 && c/b+1>0){
                Console.WriteLine(c/b+1);
            }
            else{
                Console.WriteLine("X");
            }
        }
    }
}