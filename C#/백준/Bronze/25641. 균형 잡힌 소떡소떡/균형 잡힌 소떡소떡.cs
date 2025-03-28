using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            String s = Console.ReadLine();
            int l = 0;
            int cnt = 0;
            for (int i=a-1;i>=0;i--){
                if (s[i]=='s'){
                    cnt++;
                }
                else{
                    cnt--;
                }
                if (cnt==0){
                    l=a-i;
                }
            }
            Console.WriteLine(s.Substring(a-l,l));
        }
    }
}