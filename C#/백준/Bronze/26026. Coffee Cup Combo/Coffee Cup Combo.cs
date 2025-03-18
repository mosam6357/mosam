using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int c = 0;
            int cnt = 0;
            string s = Console.ReadLine();
            for (int i=0;i<a;i++){
                if (s[i]=='1'){
                    c = 3;
                }
                if (c>0){
                    cnt++;
                    c--;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}