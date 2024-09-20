using System;

namespace q{
    class w{
        static void Main(){
            String[] aa = Console.ReadLine().Split();
            int a = int.Parse(aa[0]);
            int b = int.Parse(aa[1]);
            if(a%b==0){
                Console.WriteLine("Yes");
            }
            else{
                Console.WriteLine("No");
            }
        }
    }
}