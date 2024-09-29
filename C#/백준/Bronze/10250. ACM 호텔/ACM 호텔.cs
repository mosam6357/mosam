using System;

namespace q{
    class w{
        static void Main(){
            int q = int.Parse(Console.ReadLine());
            for (int i =0; i<q; i++){
                string[] aa = Console.ReadLine().Split();
                int a = int.Parse(aa[0]);
                int b = int.Parse(aa[1]);
                int c = int.Parse(aa[2]);
                int f = c%a;
                if(f==0){
                    f=a;
                }
                int j = (c-1)/a+1;
                if(j<10){
                    Console.WriteLine($"{f}0{j}");
                }
                else{
                    Console.WriteLine($"{f}{j}");
                }
            }
        }
    }
}