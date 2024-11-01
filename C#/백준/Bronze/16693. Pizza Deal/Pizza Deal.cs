using System;

namespace q{
    class w{
        static void Main(){
            double[] a = Array.ConvertAll(Console.ReadLine().Split(),double.Parse);
            double[] b = Array.ConvertAll(Console.ReadLine().Split(),double.Parse);
            double c1 = a[0]/a[1];
            double c2 = (b[0]*b[0]*Math.PI)/b[1];
            if(c1>c2){
                Console.WriteLine("Slice of pizza");
            }
            else{
                Console.WriteLine("Whole pizza");
            }
        }
    }
}