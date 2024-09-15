using System;

namespace q
{
    class w
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            string[] b = new string[a];
            string str = null;
            for (int i = 0; i < a; i++)
            {
                b[i] = Console.ReadLine();
            }
            int[] check = new int[b[0].Length];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b[0].Length ; j++)
                {
                    if (b[i][j] != b[0][j])
                    {
                        check[j] = 1;
                    }
                }
            }
            for (int i = 0; i < b[0].Length; i++)
            {
                if (check[i] == 1)
                {
                    str += '?';
                }
                else
                {
                    str += b[0][i];
                }
            }
            Console.WriteLine(str);
        }
    }
}