using System;

namespace q{
    class w{
        static void Main(String[] args){
            int t = int.Parse(Console.ReadLine());
            for (int i=0;i<t;i++){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                Console.WriteLine($"You get {aa[0]/aa[1]} piece(s) and your dad gets {aa[0]%aa[1]} piece(s).");
            }
        }
    }
}