using System;

namespace q{
    class w{
        static void Main(){
            string[] aa = new string[3];
            int a = 0;
            for (int i =0; i<3; i++){
                aa[i] = Console.ReadLine();
                if(aa[i][0]!='F' && aa[i][0]!='B'){
                    a = int.Parse(aa[i])+(3-i);
                }
            }
            if(a%3==0){
                Console.Write("Fizz");
            }
            if(a%5==0){
                Console.Write("Buzz");
            }
            if(a%3!=0 && a%5!=0){
                Console.Write(a);
            }
        }
    }
}