using System;

namespace q{
    class w{
        static int score(int[] a){
            return a[0]*13+a[1]*7+a[2]*5+(a[3]+a[4])*3+a[5]*2;
        }
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] bb = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            double s1 = score(aa);
            double s2 = score(bb)+1.5;
            if(s1>s2){
                Console.WriteLine("cocjr0208");
            }
            else{
                Console.WriteLine("ekwoo");
            }
        }
    }
}