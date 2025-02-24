using System;
using System.Text;

namespace q{
    class w{
        static StringBuilder sb = new StringBuilder();
        static int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
        static int n = aa[0];
        static int m = aa[1];
        static int[] path = new int[m];
        static void permu(int cnt,int min){
            if (cnt==m){
                for (int i=0;i<cnt;i++){
                    sb.Append($"{path[i]} ");
                }
                sb.AppendLine();
                return;
            }
            for(int i=min;i<n;i++){
                path[cnt]=i+1;
                permu(cnt+1,i+1);
            }
        }
        static void Main(){
            permu(0,0);
            Console.WriteLine(sb.ToString());
        }
    }
}