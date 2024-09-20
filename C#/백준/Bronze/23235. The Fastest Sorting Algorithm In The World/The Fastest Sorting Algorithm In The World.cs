using System;

namespace q{
    class w{
        static void Main(){
            int i=0;
            while(true){
                string[] aa = Console.ReadLine().Split();
                int a = int.Parse(aa[0]);
                if(a==0){
                    break;
                }
                else{
                    Console.WriteLine($"Case {i+1}: Sorting... done!");
                }
                i+=1;
            }
        }
    }
}