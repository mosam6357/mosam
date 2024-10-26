using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int s1 = a[0]*a[0]; 
            int s2 = a[1]*a[1]; 
            int s3 = a[2]*a[2];
            if(a[0]==a[1] && a[1]==a[2]){
                Console.WriteLine(2);
            }
            else if(s1==s2+s3 || s2==s1+s3 || s3==s1+s2){
                Console.WriteLine(1);
            }
            else{
                Console.WriteLine(0);
            }
        }
    }
}