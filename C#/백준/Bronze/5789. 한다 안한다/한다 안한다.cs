using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<a;i++){
                String s = Console.ReadLine();
                if (s[s.Length/2-1]==s[s.Length/2]){
                    Console.WriteLine("Do-it");
                }
                else{
                    Console.WriteLine("Do-it-Not");
                }
            }
        }
    }
}