using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            String s = Console.ReadLine();
            int cnt = 0;
            for (int i=0;i<a;i++){
                if (s[i]!=s[a-1-i]){
                    cnt++;
                }
            }
            Console.WriteLine(cnt/2);
        }
    }
}