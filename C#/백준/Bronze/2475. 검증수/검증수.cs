using System;
namespace q{
    class w{
        static void Main(){
            string[] aa = Console.ReadLine().Split();
            int sum=0;
            for (int i =0; i<5; i++){
                int a = int.Parse(aa[i]);
                sum+=a*a;
            }
            Console.WriteLine(sum%10);
        }
    }
}