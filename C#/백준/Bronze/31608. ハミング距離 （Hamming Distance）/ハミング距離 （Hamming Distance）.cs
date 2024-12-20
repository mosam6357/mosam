using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            String aa = Console.ReadLine();
            String bb = Console.ReadLine();
            int cnt = 0;
            for (int i=0; i<a; i++){
                if(aa[i]!=bb[i]){
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}