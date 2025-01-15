using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int cnt = 0;
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            for (int i=0;i<a;i++){
                if(s1[i]==s2[i] && s1[i]=='C')
                    cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}