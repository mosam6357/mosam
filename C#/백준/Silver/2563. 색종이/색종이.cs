using System;

namespace q{
    class w{
        static void Main(){
            int[,] aa = new int[100,100];
            int a = int.Parse(Console.ReadLine());
            int cnt =0;
            for (int i =0; i<a; i++){
                string[] bb = Console.ReadLine().Split();
                int b = int.Parse(bb[0]);
                int c = int.Parse(bb[1]);
                for (int j =0; j<10; j++){
                    for (int k=0; k<10; k++){
                        if(aa[b+j,c+k]==0){
                            cnt++;
                            aa[b+j,c+k]=1;
                        }
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}