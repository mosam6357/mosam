using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int sum=0;
            if(a==0){
                Console.WriteLine("divide by zero");
            }
            else{
                string[] aa = Console.ReadLine().Split();
                for (int i =0; i<aa.Length; i++){
                    sum+=int.Parse(aa[i]);
                }
                if(sum==0){
                    Console.WriteLine("divide by zero");
                }
                else{
                    Console.WriteLine("1.00");
                }
            }
        }
    }
}