using System;

namespace q{
    class w{
        static void Main(){
            int t = int.Parse(Console.ReadLine());
            for (int i=0;i<t;i++){
                int n = int.Parse(Console.ReadLine());
                int a = n/1000;
                int b = n%1000/100;
                int c = n%100/10;
                int d = n%10;
                int p1 = (a*10+b)*(a*10+b);
                int p2 = (c*10+d)*(c*10+d);
                if ((p1+p2)%7==1){
                    Console.WriteLine("YES");
                }
                else{
                    Console.WriteLine("NO");
                }
            }
        }
    }
}