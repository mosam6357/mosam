using System;

namespace q{
    class w{
        static void Main(String[] args){
            int t = int.Parse(Console.ReadLine());
            for (int i=0;i<t;i++){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int a = aa[0]; int b = aa[1];
                Console.WriteLine($"Data Set {i+1}:");
                if (a<=b){
                    Console.WriteLine("no drought\n");
                }
                else{
                    String s = "";
                    while(true){
                        if (a>b && a<=b*5){
                            s+="drought\n";
                            break;
                        }
                        else{
                            s+="mega ";
                            b*=5;
                        }
                    }
                    Console.WriteLine(s);
                }
            }
        }
    }
}