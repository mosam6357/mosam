using System;

namespace q{
    class w{
        static void Main(String[] args){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int n1 = aa.Where(n=>n==1).Count();
            int n2 = aa.Where(n=>n==2).Count();
            int n3 = aa.Where(n=>n==3).Count();
            int total = 5000-n1*500-n2*800-n3*1000;
            Console.WriteLine(total);
        }
    }
}