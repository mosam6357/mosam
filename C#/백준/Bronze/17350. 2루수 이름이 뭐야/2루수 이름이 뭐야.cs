using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a =  int.Parse(Console.ReadLine());
            for (int i=0;i<a;i++){
                string s = Console.ReadLine();
                if (s.Equals("anj")){
                    Console.WriteLine("뭐야;");
                    break;
                }
                if (i==a-1){
                    Console.WriteLine("뭐야?");
                }
            }
        }
    }
}