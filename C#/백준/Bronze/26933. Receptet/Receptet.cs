using System;

namespace q{
    class w{
        static void Main(){
            int t = int.Parse(Console.ReadLine());
            int s = 0;
            for (int i=0; i<t;i++){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                if(aa[0]<aa[1]){
                    s+=(aa[1]-aa[0])*aa[2];
                }
            }
            Console.WriteLine(s);
        }
    }
}