using System;

namespace q{
    class w{
        static void Main(){
            int t = int.Parse(Console.ReadLine());
            for(int i =0; i<t; i++){
                string[] aa = Console.ReadLine().Split();
                double a = double.Parse(aa[0]);
                double b = double.Parse(aa[1]);
                if(a%10==0){
                    Console.WriteLine(10);
                }
                else{
                    double c = b%4;
                    if(c==0){
                        double d = Math.Pow(a,c+4);
                        double e = d%10;
                        Console.WriteLine(e);
                    }                    
                    else{
                        double d = Math.Pow(a,c);
                        double e = d%10;
                        Console.WriteLine(e);                        
                    }
                }
            }
        }
    }
}