using System;

namespace q{
    class w{
        static void Main(){
            string[] aa = Console.ReadLine().Split();
            int sum=0;
            for (int i =0; i<3; i++){
                if(i<2){
                    sum+=int.Parse(aa[i]);
                }
                else{
                    if(int.Parse(aa[2])==sum){
                        Console.Write("correct!");
                    }
                    else{
                        Console.Write("wrong!");
                    }
                }
            }
        }
    }
}