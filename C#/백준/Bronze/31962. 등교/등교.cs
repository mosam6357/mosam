using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] ans = new int[aa[0]];
            for (int i =0; i<aa[0]; i++){
                int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                if(bb[0]+bb[1]<=aa[1]){
                    ans[i]=bb[0];
                }
            }
            if(ans.Sum()==0){
                Console.WriteLine(-1);
            }
            else{
                Console.WriteLine(ans.Max());
            }
        }
    }
}