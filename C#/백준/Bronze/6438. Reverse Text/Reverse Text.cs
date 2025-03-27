using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<a;i++){
            String s = Console.ReadLine();
            for (int j=s.Length-1;j>=0;j--){
                Console.Write(s[j]);
            }
            Console.WriteLine();
            }
        }
    }
}