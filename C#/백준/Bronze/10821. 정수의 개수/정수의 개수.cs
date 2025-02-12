using System;

namespace q{
    class w{
        static void Main(){
            String a = Console.ReadLine();
            int cnt=1;
            for (int i=0;i<a.Length;i++){
                if (a[i]==','){
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}