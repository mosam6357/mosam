using System;

namespace q{
    class w{
        static void Main(){
            int[] a = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
            int zsum = 0;
            int osum = 0;
            for (int i =0; i<a[0]; i++){
                String b = Console.ReadLine();
                for (int j=0; j<a[1]; j++){
                    if(b[j]=='0'){
                        zsum++;
                    }
                    else{
                        osum++;
                    }
                }
            }
            if(zsum>osum){
                Console.WriteLine(osum);
            }
            else{
                Console.WriteLine(zsum);
            }
        }
    }
}