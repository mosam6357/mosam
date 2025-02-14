using System;

public class Example
{
    public static void Main()
    {
        String s;
        s = Console.ReadLine();
        for (int i=0;i<s.Length;i++){
            if ((char)s[i]<97){
                Console.Write((char)(s[i]+'a'-'A'));
            }
            else{
                Console.Write((char)(s[i]-('a'-'A')));
            }
        }

    }
}