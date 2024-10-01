using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace q{
    class w{
        static void Main(string[] args){
            StringBuilder sb = new StringBuilder();
            int a = int.Parse(Console.ReadLine());
            var aa = new List<int[]>();
            for (int i =0; i<a; i++){
                string[] q = Console.ReadLine().Split();
                int[] w = Array.ConvertAll(q,int.Parse);
                aa.Add(w);
            }
            var bb = aa.OrderBy(x=>x[0]).ThenBy(x=>x[1]).ToList();
            for (int i =0; i<a; i++){
                sb.Append($"{bb[i][0]} {bb[i][1]}\n");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}