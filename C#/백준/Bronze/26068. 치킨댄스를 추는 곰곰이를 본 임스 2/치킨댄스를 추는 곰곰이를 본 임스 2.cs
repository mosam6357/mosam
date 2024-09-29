using System;

namespace q{
    class w{
        static void Main(){
            int q = int.Parse(Console.ReadLine()); int sum=0;
            for(int i =0; i<q; i++){
                int a = int.Parse(Console.ReadLine().Substring(2));
                if(a<=90){
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}