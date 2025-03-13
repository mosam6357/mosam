using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            int cnt = 0;
            for (int i=2;i<1000;i++){
                for (int j=1;j<i;j++){
                    if (i*i==j*j+a){
                        cnt++;
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}