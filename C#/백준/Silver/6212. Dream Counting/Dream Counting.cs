using System;

namespace q{
    class w{
        static void Main(){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] a = new int[10];
            for (int i=aa[0];i<aa[1]+1;i++){
                string s = i.ToString();
                for (int j=0;j<s.Length;j++){
                    a[s[j]-'0']++;
                }
            }
            for (int i=0;i<10;i++){
                Console.Write($"{a[i]} ");
            }
        }
    }
}