using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<a;i++){
                string s = Console.ReadLine();
                Console.WriteLine(s.ToUpper().Substring(0,1)+s.Substring(1));
            }
        }
    }
}