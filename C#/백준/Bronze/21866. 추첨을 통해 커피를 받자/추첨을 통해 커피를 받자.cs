using System;
using System.Linq;
namespace q{
    class w{
        static void Main(String[] args){
            int[] aa = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int[] cc = {100, 100, 200, 200, 300, 300, 400, 400, 500};
            int h = 0;
            for (int i=0;i<9;i++){
                if (aa[i]>cc[i]){
                    h=1;
                    break;
                }
            }
            if (h==1){
                Console.WriteLine("hacker");
            }
            else if (aa.Sum()>=100){
                Console.WriteLine("draw");
            }
            else{
                Console.WriteLine("none");
            }
        }
    }
}