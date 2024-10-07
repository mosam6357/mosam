using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int up = 0; int rt = 0;
            string b = Console.ReadLine();
            for (int i =0; i<a; i++){
                if(b[i]=='N'){
                    up++;
                }
                else if(b[i]=='S'){
                    up--;
                }
                else if(b[i]=='E'){
                    rt++;
                }
                else{
                    rt--;
                }
            }
            up = up>0?up:-up;
            rt = rt>0?rt:-rt;
            Console.WriteLine(up+rt);
        }
    }
}