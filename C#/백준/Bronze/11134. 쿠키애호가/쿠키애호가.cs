using System;

namespace q{
    class w{
        static void Main(String[] args){
            int t = int.Parse(Console.ReadLine());
            for (int i=0;i<t;i++){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int a = aa[0];
                int b = aa[1];
                if (a%b==0){
                    Console.WriteLine(a/b);
                }
                else{
                    Console.WriteLine(a/b+1);
                }
            }
        }
    }
}