using System;
using System.Linq;

namespace q{
    class w{
        static void Main(){
            string c = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int cnt = 1;
            int[] q = new int[26];
            q[(int)(c[0])-65]++;
            for (int i=0;i<a;i++){
                string[] aa = Console.ReadLine().Split();
                if (aa[1][0]==c[0]){
                    c = aa[0];
                    q[(int)(c[0])-65]=1;
                }
            }
            Console.WriteLine(c);
            Console.WriteLine(q.Sum());
        }
    }
}