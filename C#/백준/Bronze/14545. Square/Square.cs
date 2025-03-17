using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<a;i++){
                int n = int.Parse(Console.ReadLine());
                int total = 0;
                for (int j=1;j<=n;j++){
                    total+=j*j;
                }
                Console.WriteLine(total);
            }
        }
    }
}