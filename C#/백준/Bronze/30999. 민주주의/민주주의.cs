using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int a = aa[0]; int b = aa[1]; int cnt =0;
            for (int i=0; i<a; i++){
                string s = Console.ReadLine();
                int o=0;
                for (int j=0; j<b; j++){
                    if(s[j]=='O'){
                        o++;
                    }
                    else{
                        o--;
                    }
                }
                if(o>0){
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}