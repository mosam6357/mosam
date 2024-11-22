using System;

namespace q{
    class w{
        static void Main(){
            string a = Console.ReadLine();
            int cnt1 = 0;
            int cnt2 = 0;
            for (int i =0; i<a.Length; i++){
                if(a[i]=='a' || a[i]=='e'||a[i]=='i'||a[i]=='o'||a[i]=='u'){
                    cnt1++;
                }
                else if(a[i]=='y'){
                    cnt2++;
                }
            }
            Console.WriteLine($"{cnt1} {cnt1+cnt2}");
        }
    }
}