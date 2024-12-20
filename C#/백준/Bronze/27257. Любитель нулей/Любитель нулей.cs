using System;

namespace q{
    class w{
        static void Main(){
            String a = Console.ReadLine();
            int ck = 0; int cnt = 0;
            for (int i = a.Length-1; i>-1; i--){
                if(ck==0 && a[i]!='0'){
                    ck=1;
                }
                if(ck==1 && a[i]=='0'){
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}