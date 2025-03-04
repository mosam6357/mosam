using System;

namespace q{
    class w{
        static void Main(){
            int t = int.Parse(Console.ReadLine());
            for (int i=0;i<t;i++){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int min = 101;
                int sum = 0;
                for (int j=0;j<7;j++){
                    if (aa[j]%2==0){
                        min=min<aa[j]?min:aa[j];
                        sum+=aa[j];
                    }
                }
                Console.WriteLine($"{sum} {min}");
            }
        }
    }
}