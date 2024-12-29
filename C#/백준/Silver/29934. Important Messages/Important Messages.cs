using System;

namespace q{
    class w{
        static void Main(){
            int a = int.Parse(Console.ReadLine());
            int cnt =0;
            String[] aa = new String[a];
            for (int i=0;i<a;i++){
                aa[i] = Console.ReadLine();
            }
            int b = int.Parse(Console.ReadLine());
            for (int i=0;i<b;i++){
                String s = Console.ReadLine();
                for (int j=0;j<a;j++){
                    if(s.Equals(aa[j])){
                        cnt++;
                        break;
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}