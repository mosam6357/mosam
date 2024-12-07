using System;

namespace q{
    class w{
        static void Main(String[] args){
            int t = int.Parse(Console.ReadLine());
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            if(aa.Sum()<t && t>240){
                Console.WriteLine("flight");
            }
            else{
                Console.WriteLine("high speed rail");
            }
        }
    }
}