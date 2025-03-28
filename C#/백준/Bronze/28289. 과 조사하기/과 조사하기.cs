using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int[] s = new int[4];
            for (int i=0;i<a;i++){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int b = aa[0]; int c = aa[1]; int d = aa[2];
                if (b==1){
                    s[3]++;
                }
                else if(c==1 || c==2){
                    s[0]++;
                }
                else if(c==3){
                    s[1]++;
                }
                else{
                    s[2]++;
                }
            }
            for (int i=0;i<4;i++){
                Console.WriteLine(s[i]);
            }
        }
    }
}