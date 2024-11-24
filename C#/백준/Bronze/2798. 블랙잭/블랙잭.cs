using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int n = a[0];
            int lim = a[1];
            int sum = 0;
            for(int i =0; i<n-2; i++){
                for(int j=i+1; j<n-1; j++){
                    for(int k=j+1;k<n;k++){
                        int b = aa[i]+aa[j]+aa[k];
                        if(b>sum && b<=lim){
                            sum=b;
                        }
                    }
                }
                if(sum==lim){break;}
            }
            Console.WriteLine(sum);
        }
    }
}