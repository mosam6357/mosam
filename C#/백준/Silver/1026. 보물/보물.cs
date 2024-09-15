using System;

namespace q
{
    class w
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            string[] bb = Console.ReadLine().Split();
            string[] cc = Console.ReadLine().Split();
            int sum1 = 0;
            int sum2 = 0;
            int[] b = new int[a];
            int[] c = new int[a];
            for (int i = 0; i < a; i++)
            {
                b[i] = Convert.ToInt32(bb[i]);
                c[i] = Convert.ToInt32(cc[i]);
            }
            Array.Sort(b);
            Array.Sort(c);
            Array.Reverse(c);
            for (int i = 0; i < a; i++)
            {
                sum1 += b[i] * c[i];
            }
            Console.WriteLine(sum1);
        }
    }
}