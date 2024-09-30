using System;
using System.Linq;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int[] aa = new int[26];
            for (int i =0; i<a; i++){
                string[] bb = Console.ReadLine().Split();
                for (int j =0; j<26; j++){
                    int b = bb[0].Count(f => (f==(char)(97+j)));
                    int c = bb[1].Count(f => (f==(char)(97+j)));
                    int e=b>c?b:c;
                    aa[j]+=e;
                }
            }
            for(int i =0; i<26; i++){
                Console.WriteLine(aa[i]);
            }
        }
    }
}