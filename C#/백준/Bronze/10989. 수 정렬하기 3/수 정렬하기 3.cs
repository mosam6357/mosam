using System;
using System.Text;
using System.IO;

namespace q{
    class w{
        static void Main(){
            int[] aa = new int[10000];
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int a = int.Parse(sr.ReadLine());
            for (int i=0;i<a;i++){
                aa[int.Parse(sr.ReadLine())-1]++;
            }
            for (int i=0;i<10000;i++){
                for (int j=0;j<aa[i];j++){
                    sw.WriteLine(i+1);
                }
            }
            sr.Close();
            sw.Close();
        }
    }
}