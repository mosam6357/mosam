using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int cnt = 0;
            int save = 0;
            for (int i=0; i<aa[0]; i++){
                string a = Console.ReadLine();
                if(a[1]=='a'){
                    save = cnt;
                    Console.WriteLine(cnt);
                }
                if(a[1]=='o'){
                    cnt=save;
                    Console.WriteLine(cnt);
                }
                if(a[1]=='h'){
                    Console.WriteLine(--cnt);
                }
                if(a[1]=='m'){
                    cnt+=aa[1];
                    Console.WriteLine(cnt);
                }
            }
        }
    }
}