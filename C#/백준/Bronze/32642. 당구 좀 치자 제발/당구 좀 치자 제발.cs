using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int[] b = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            long s = 0;
            long ans = 0;
            for (int i=0; i<a; i++){
                if(b[i]==1){
                    s++;
                }
                else{
                    s--;
                }
                ans+=s;
            }
            Console.WriteLine(ans);
        }
    }
}