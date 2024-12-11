using System;
using System.Linq;

namespace q{
    class w{
        static void Main(){
            int[] aa =Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            if(aa.Max()*2==aa.Sum()){
                Console.WriteLine(1);
            }
            else if(aa.Max()==(aa.Sum()-aa.Min()-aa.Max())*aa.Min()){
                Console.WriteLine(2);
            }
            else{
                Console.WriteLine(3);
            }
        }
    }
}