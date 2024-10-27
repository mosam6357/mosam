using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] b = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            if(a[1]<=b[0] || b[1]<=a[0]){
                Console.WriteLine(a[1]-a[0]+b[1]-b[0]);
            }
            else{
                int[] c = a.Concat(b).ToArray();
                Console.WriteLine(c.Max()-c.Min());
            }
        }
    }
}