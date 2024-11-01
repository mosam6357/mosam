using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i=0; i<a; i++){
                string b = Console.ReadLine();
                int ans = 0;
                int sqrt = 1;
                for (int j=0;j<24;j++){
                    if(b[23-j]=='1'){
                        ans+=sqrt;
                    }
                    sqrt*=2;
                }
                Console.WriteLine(ans);
            }
        }
    }
}