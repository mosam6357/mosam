using System;

namespace q{
    class w{
        static void Main(){
            String[] aa = Console.ReadLine().Split();
            int a = int.Parse(aa[0])+int.Parse(aa[2]);
            if(a==int.Parse(aa[4])){
                Console.WriteLine("YES");
            }
            else{
                Console.WriteLine("NO");
            }
        }
    }
}