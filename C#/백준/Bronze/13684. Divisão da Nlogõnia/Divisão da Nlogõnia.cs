using System;

namespace q{
    class w{
        static void Main(String[] args){
            while(true){
                int t = int.Parse(Console.ReadLine());
                if (t==0){
                    break;
                }
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int a = aa[0]; int b = aa[1];
                for (int i=0;i<t;i++){
                    int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                    int c = bb[0]; int d = bb[1];
                    if (c==a || d==b){
                        Console.WriteLine("divisa");
                    }
                    else if(c>a && d>b){
                        Console.WriteLine("NE");
                    }
                    else if(c<a && d>b){
                        Console.WriteLine("NO");
                    }
                    else if(c<a && d<b){
                        Console.WriteLine("SO");
                    }
                    else{
                        Console.WriteLine("SE");
                    }
                }
            }
        }
    }
}