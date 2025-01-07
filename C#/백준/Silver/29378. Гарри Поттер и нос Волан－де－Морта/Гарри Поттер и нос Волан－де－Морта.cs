using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int a = aa[0];
            int b = aa[1];
            int cnt = 0;
            string[] s = new string[a];
            for (int i=0;i<a;i++){
                s[i] = Console.ReadLine();
            }
            for (int i=0;i<a;i++){
                for (int j=0;j<b-1;j++){
                    if(s[i][j]==s[i][j+1] && s[i][j]=='.'){cnt++;}
                }
            }
            for (int i=0;i<b;i++){
                for (int j=0;j<a-1;j++){
                    if(s[j][i]==s[j+1][i] && s[j][i]=='.'){cnt++;}
                }
            }
            Console.WriteLine(cnt);
        }
    }
}