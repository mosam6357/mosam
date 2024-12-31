using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int a = aa[0]; int b = aa[1];
            string s = Console.ReadLine();
            int p = 1;
            int fail= 0 ;
            for (int i=0;i<a;i++){
                if(s[i]=='L'){
                    if(p==0){
                        fail++;
                    }
                    p=0;
                }
                else{
                    if(p==1){
                        fail++;
                    }
                    p=1;
                }
            }
            Console.WriteLine((fail>b)?0:b-fail);
        }
    }
}