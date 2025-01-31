using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<a;i++){
                string[] aa = Console.ReadLine().Split("-");
                string s = aa[0];
                int n1 = 0;
                int n2 = int.Parse(aa[1]);
                int p = 26*26;
                for (int j=0;j<3;j++){
                    n1+=(s[j]-'A')*p;
                    p/=26;
                }
                if(Math.Abs(n1-n2)<=100){
                    Console.WriteLine("nice");
                }
                else{
                    Console.WriteLine("not nice");
                }
            }
        }
    }
}