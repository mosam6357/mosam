using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int a = aa[0];
            int b = aa[1];
            int c = aa[2];
            for (int i=0;i<a;i++){
                int n = int.Parse(Console.ReadLine());
                if (n*n<=b*b+c*c){
                    Console.WriteLine("DA");
                }
                else{
                    Console.WriteLine("NE");
                }
            }
        }
    }
}