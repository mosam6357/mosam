using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int[] aa = new int[26];
            for(int i =0; i<a; i++){
                string b = Console.ReadLine();
                aa[(int)b[0]-97]++;
            }
            int check=0;
            for(int i=0; i<26; i++){
                if(aa[i]>=5){
                    Console.Write((char)(i+97));
                    check=1;
                }
            }
            if(check==0){
                Console.Write("PREDAJA");
            }
        }
    }
}