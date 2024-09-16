using System;

namespace q{
    class w{
        static void Main(){
            string a = Console.ReadLine();
            char[] aa = a.ToArray();
            int[] bb = new int[26];
            for(int i =0; i<aa.Length; i++){
                if((int)aa[i]<=90){
                    bb[(int)aa[i]-65]+=1;
                }
                else{
                    bb[(int)aa[i]-97]+=1;
                }
            }
            int c = bb.Max();
            int d = 0;
            int count = 0;
            for(int i = 0; i<26; i++){
                if(bb[i] == c){
                    count++;
                    d=i;
                }
            }
            int e = d+65;
            if(count==1){
                Console.WriteLine((char)e);
            }
            else{
                Console.WriteLine("?");
            }
        }
    }
}