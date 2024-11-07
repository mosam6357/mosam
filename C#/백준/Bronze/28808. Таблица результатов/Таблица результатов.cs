using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int cnt = 0;
            for (int i=0; i<a[0]; i++){
                string aa = Console.ReadLine();
                for (int j=0; j<a[1]; j++){
                    if(aa[j]=='+'){
                        cnt++;
                        break;
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}