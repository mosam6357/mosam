using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int n = 1;
            for (int i=1;i<a;i++){
                if (i>a-4){
                    n*=i;
                }
            }
            n/=6;
            Console.WriteLine(n);
        }
    }
}