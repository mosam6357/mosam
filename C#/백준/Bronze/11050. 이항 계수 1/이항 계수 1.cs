using System;

namespace q{
    class w{
        static void Main(){
            string[] aa = Console.ReadLine().Split();
            int a = int.Parse(aa[0]); int b = int.Parse(aa[1]);
            int c=1; int d=1; int e=1;
            for (int i =0; i<a; i++){
                c*=i+1;
            }
            for (int i =0; i<a-b; i++){
                d*=i+1;
            }
            for(int i=0; i<b; i++){
                e*=i+1;
            }
            Console.WriteLine(c/(d*e));
        }
    }
}