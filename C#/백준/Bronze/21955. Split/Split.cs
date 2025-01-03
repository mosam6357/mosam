using System;

namespace q{
    class w{
        static void Main(){
            string s = Console.ReadLine();
            for (int i=0;i<s.Length+1;i++){
                if(i<s.Length/2){
                    Console.Write(s[i]);
                }
                else if(i==s.Length/2){
                    Console.Write(" ");
                }
                else{
                    Console.Write(s[i-1]);
                }
            }
        }
    }
}