using System;

namespace q{
    class w{
        static void Main(){
            string[] aa = Console.ReadLine().Split();
            int a = int.Parse(aa[0]); int b = int.Parse(aa[1]);
            if(a>=b/2 && b%2==0){
                Console.WriteLine('E');
            }
            else if(a>b/2 && b%2==1){
                Console.WriteLine('E');
            }
            else{
                Console.WriteLine('H');
            }
        }
    }
}