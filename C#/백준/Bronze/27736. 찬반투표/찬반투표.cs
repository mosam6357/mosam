using System;
using System.Linq;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int cnt = aa.Where(n => n==0).Count();
            if (cnt*2>=a){
                Console.WriteLine("INVALID");
            }
            else if(aa.Sum()>0){
                Console.WriteLine("APPROVED");
            }
            else{
                Console.WriteLine("REJECTED");
            }
        }
    }
}