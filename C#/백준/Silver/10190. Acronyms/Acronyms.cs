using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<a;i++){
                String[] aa = Console.ReadLine().Split();
                String s1 = aa[0];
                int n = int.Parse(aa[1]);
                Console.WriteLine(s1);
                for (int j=0;j<n;j++){
                    String b = Console.ReadLine();
                    String[] bb =b.Split();
                    String s2 = "";
                    for (int k=0;k<bb.Length;k++){
                        s2+=bb[k][0];
                    }
                    if(s1.Equals(s2)){
                        Console.WriteLine(b);
                    }
                }
            }
        }
    }
}