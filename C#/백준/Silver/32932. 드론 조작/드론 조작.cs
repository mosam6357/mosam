using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] q = new int[aa[0]];
            int[] w = new int[aa[0]];
            for (int i=0; i<aa[0]; i++){
                int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                q[i] = bb[0];
                w[i] = bb[1];
            }
            string a = Console.ReadLine();
            int x=0,y=0;
            for (int i=0; i<aa[1]; i++){
                int f1=x,f2=y;
                if(a[i]=='L'){f1--;}
                if(a[i]=='R'){f1++;}
                if(a[i]=='D'){f2--;}
                if(a[i]=='U'){f2++;}
                for (int j=0; j<aa[0]; j++){
                    if(f1==q[j] && f2==w[j]){
                        break;
                    }
                    if(j==aa[0]-1){
                        x=f1;
                        y=f2;
                    }
                }
            }
            Console.WriteLine($"{x} {y}");
        }
    }
}