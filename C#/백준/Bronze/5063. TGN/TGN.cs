using System;

namespace q{
    class w{
        static void Main(String[] args){
            int t = int.Parse(Console.ReadLine());
            for (int i=0;i<t;i++){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int a = aa[0]; int b = aa[1]; int c = aa[2];
                if(a<b-c){
                    Console.WriteLine("advertise");
                }
                else if(a==b-c){
                    Console.WriteLine("does not matter");
                }
                else{
                    Console.WriteLine("do not advertise");
                }
            }
        }
    }
}