using System;

namespace q{
    class w{
        static void Main(){
            string[] aa = Console.ReadLine().Split();
            int a = int.Parse(aa[0]); int b = int.Parse(aa[1]);
            int[,] ans= new int[a,b];
            for(int i =0; i<2; i++){
                for(int j =0; j<a; j++){
                    string[] bb = Console.ReadLine().Split();
                    for(int k=0; k<b; k++){
                        ans[j,k]+=int.Parse(bb[k]);
                    }
                }
            }
            for(int i=0; i<a; i++){
                for(int j=0; j<b; j++){
                    Console.Write(ans[i,j]+" ");                    
                }
                Console.WriteLine();
            }
        }
    }
}