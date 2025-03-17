using System;
using System.Linq;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int max = n;
            for (int i=0;i<a;i++){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                n+=aa[0]-aa[1];
                if (n<0){
                    max = 0;
                    break;
                }
                max = max>n?max:n;
            }
            Console.WriteLine(max);
        }
    }
}