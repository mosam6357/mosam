using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            String s = Console.ReadLine();
            for (int i=1;i<a*2;i++){
                if (s[i-1]==s[i]){
                    Console.WriteLine("No");
                    break;
                }
                if (i==a*2-1){
                    Console.WriteLine("Yes");
                }
            }
        }
    }
}