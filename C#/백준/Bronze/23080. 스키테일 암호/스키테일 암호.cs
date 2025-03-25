using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            String s = Console.ReadLine();
            for (int i=0;i<s.Length;i+=a){
                Console.Write(s[i]);
            }
        }
    }
}