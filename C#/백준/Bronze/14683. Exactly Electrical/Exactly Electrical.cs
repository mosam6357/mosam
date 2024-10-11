using System;

namespace q{
    class w{
        static void Main(){
            string[] aa = Console.ReadLine().Split();
            string[] bb = Console.ReadLine().Split();
            int a = int.Parse(aa[0]);
            int b = int.Parse(aa[1]);
            int c = int.Parse(bb[0]);
            int d = int.Parse(bb[1]);
            int e = int.Parse(Console.ReadLine());
            int s1 = a>c?a-c:c-a;
            int s2 = b>d?b-d:d-b;
            if(s1+s2>e){
                Console.WriteLine('N');
            }
            else{
                if((s1+s2)%2==e%2){
                    Console.WriteLine('Y');
                }
                else{
                    Console.WriteLine('N');
                }
            }
        }
    }
}