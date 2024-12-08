using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i=0; i<a; i++){
                int[] aa = Array.ConvertAll(Console.ReadLine().Trim().Split(),int.Parse);
                int esum = 0; //짝수합
                int osum = 0; //홀수합
                for (int j=1; j<aa.Length; j++){
                    if(aa[j]%2==0){
                        esum+=aa[j];
                    }
                    else{
                        osum+=aa[j];
                    }
                }
                if(esum==osum){
                    Console.WriteLine("TIE");
                }
                else if(esum>osum){
                    Console.WriteLine("EVEN");
                }
                else{
                    Console.WriteLine("ODD");
                }
            }
        }
    }
}