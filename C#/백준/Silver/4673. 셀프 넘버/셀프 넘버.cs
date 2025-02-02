using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = new int[10000];
            for (int i=0;i<10000;i++){
                int n = i+1;
                string s = n.ToString();
                for (int j=0;j<s.Length;j++){
                    n+=s[j]-'0';
                }
                if (n<=10000){
                    aa[n-1]=1;
                }
            }
            for (int i=0;i<10000;i++){
                if (aa[i]==0){
                    Console.WriteLine(i+1);
                }
            }
        }
    }
}