using System;

namespace q{
    class w{
        static void Main(){
            int[] a = new int[2];
            for (int i=0;i<2;i++){
                int[] b = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                a[i] = b[0]+b[1]*2+b[2]*3;
            }
            if(a[0]==a[1]){
                Console.WriteLine(0);
            }
            else{
                Console.WriteLine(a[0]>a[1]?1:2);
            }
        }
    }
}