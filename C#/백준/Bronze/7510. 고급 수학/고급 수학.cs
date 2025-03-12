using System;
using System.Linq;

namespace q{
    class w{
        static void Main(String[] args){
            int t = int.Parse(Console.ReadLine());
            for (int i=0;i<t;i++){
                int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                int total = aa.Min()*aa.Min()+(aa.Sum()-aa.Max()-aa.Min())*(aa.Sum()-aa.Max()-aa.Min());
                if(aa.Max()*aa.Max()==total){
                    Console.WriteLine($"Scenario #{i+1}:\nyes\n");
                }
                else{
                    Console.WriteLine($"Scenario #{i+1}:\nno\n");
                }
            }
        }
    }
}