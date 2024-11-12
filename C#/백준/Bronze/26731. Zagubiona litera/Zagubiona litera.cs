using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = new int[26];
            string a = Console.ReadLine();
            for (int i=0; i<25; i++){
                aa[(int)a[i]-65]++;
            }
            for (int i=0; i<26; i++){
                if(aa[i]==0){
                    Console.WriteLine((char)(i+65));
                }
            }
        }
    }
}