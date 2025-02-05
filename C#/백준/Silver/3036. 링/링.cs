using System;
using System.Linq;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            for (int i=1;i<a;i++){
                int b = aa[0];
                int c = aa[i];
                int j = 2;
                while(true){
                    if(b%j==0 && c%j==0){
                        b/=j;
                        c/=j;
                        j=1;
                    }
                    if(j>=b || j>=c)
                        break;
                    j++;
                }
                Console.WriteLine($"{b}/{c}");
            }
        }
    }
}