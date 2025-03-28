using System;

namespace q{
    class w{
        static void Main(String[] args){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int a = aa[0];
            int b = aa[1];
            int l = 0;
            int n = 0;
            for (int i=0;i<a;i++){
                int cnt = 0;
                String s = Console.ReadLine();
                for (int j=0;j<b;j++){
                    if (s[j]=='1' && (j==0 || s[j-1]=='0')){
                        cnt++;
                    }
                }
                if (l<cnt){
                    n = 1;
                }
                else if(l==cnt){
                    n++;
                }
                l = l>cnt?l:cnt;
            }
            Console.WriteLine($"{l} {n}");
        }
    }
}