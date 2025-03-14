using System;

namespace q{
    class w{
        static void Main(String[] args){
            while(true){
                string s = Console.ReadLine();
                if (s.Equals("***")){
                    break;
                }
                for (int i=s.Length-1;i>=0;i--){
                    Console.Write(s[i]);
                }
                Console.WriteLine();
            }
        }
    }
}