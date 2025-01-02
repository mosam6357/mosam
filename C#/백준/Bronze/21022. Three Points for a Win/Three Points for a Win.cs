using System;
using System.Linq;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int s = 0;
            for (int i=0;i<a;i++){
                if (aa[i]>bb[i]){
                    s+=3;
                }
                else if(aa[i]==bb[i]){
                    s++;
                }
            }
            Console.WriteLine(s);
        }
    }
}