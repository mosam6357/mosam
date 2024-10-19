using System;

namespace q{
    class w{
        static void Main(){
            string a = Console.ReadLine();
            int sum1=0;
            int sum2=0;
            for (int i =0; i<a.Length; i++){
                if(a[i]=='A'){
                    sum1++;
                }
                else{
                    sum2++;
                }
            }
            Console.WriteLine($"{sum1} : {sum2}");
        }
    }
}