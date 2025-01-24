using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int x = 1;
            int cnt = 0;
            for (int i=0;i<a;i++){
                if(s[i]=='L'){
                    if(x!=1){x--;}
                }
                else{
                    if(x!=3){x++;}
                    if(x==3){cnt++;}
                }
            }
            Console.WriteLine(cnt);
        }
    }
}