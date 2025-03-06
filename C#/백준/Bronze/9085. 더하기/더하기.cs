using System;
using System.Linq;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<a;i++){
                string s = Console.ReadLine();
                Console.WriteLine(Array.ConvertAll(Console.ReadLine().Split(),int.Parse).Sum());
            }
        }
    }
}