using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int sum=0;
            string[] aa = Console.ReadLine().Split();
            for (int i =0; i<a; i++){
                sum+=int.Parse(aa[i]);
            }
            if(sum==0){
                Console.Write("Stay");
            }
            else if(sum>0){
                Console.Write("Right");
            }
            else{
                Console.Write("Left");
            }
        }
    }
}