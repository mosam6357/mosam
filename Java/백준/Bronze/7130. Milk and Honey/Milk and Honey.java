import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int t = in.nextInt();
        int ans =  0;
        for (int i=0;i<t;i++){
            int q = in.nextInt();
            int w = in.nextInt();
            ans+=a*q>b*w?a*q:b*w;
        }
        System.out.println(ans);
    }
}