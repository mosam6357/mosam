import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        long[] s = {0,0,1};
        for (int i=0; i<a;i++){
            long s0 = s[0]-s[2];
            long s1 = s[1]+s[2];
            long s2 = 2*(s[0]-s[1])+s[2];
            s[0] = s0; s[1]=s1; s[2]=s2;
        }
        System.out.println(s[0]+s[1]+s[2]);
    }
}