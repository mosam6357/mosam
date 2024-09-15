using System;
using System.Collections.Generic;
namespace q{
    class w{
        static void Main(){
            List<string> a = new List<string>() {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
            long sum=10*a.IndexOf(Console.ReadLine())+a.IndexOf(Console.ReadLine());
            long b = a.IndexOf(Console.ReadLine()); long c = 1;
            for(int i =0; i<b; i++){
                c*=10;
            }
            sum*=c;
            Console.WriteLine(sum);
        }
    }
}