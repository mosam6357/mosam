using System;

namespace q{
    class w{
        static void Main(){
            string s = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            for (int i=0;i<a;i++){
                int cnt1 = 0;
                int cnt2 = 0;
                string q = Console.ReadLine();
                for (int j = 0; j<4;j++){
                    for (int k = 0; k<4;k++){
                        if(q[j]==s[k]){
                            cnt1++;
                            break;
                        }
                    }
                    if(q[j]==s[j]){
                        cnt2++;
                    }
                }
                Console.WriteLine($"{cnt1} {cnt2}");
            }
            
        }
    }
}