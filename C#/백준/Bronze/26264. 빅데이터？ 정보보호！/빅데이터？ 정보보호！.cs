using System;

namespace q{
    class w{
        static void Main(String[] args){
            int a = int.Parse(Console.ReadLine());
            String s = Console.ReadLine();
            int l = s.Length;
            if (l-7.5*a>0){
                Console.WriteLine("security!");
            }
            else if(l-7.5*a==0){
                Console.WriteLine("bigdata? security!");
            }
            else{
                Console.WriteLine("bigdata?");
            }
        }
    }
}