using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int q=0; q<a; q++){
                int b = int.Parse(Console.ReadLine());
                if(b==0 || b==1){
                    Console.WriteLine($"{1-b} {b}");
                }
                else{
                    int[] z = new int[b+1];
                    int[] o = new int[b+1];
                    z[0]=1; z[1]=0; o[0]=0; o[1]=1;
                    for(int i=2; i<b+1; i++){
                        z[i] = z[i-1]+z[i-2];
                        o[i] = o[i-1]+o[i-2];
                    }
                    Console.WriteLine($"{z[b]} {o[b]}");
                }
            }
        }
    }
}