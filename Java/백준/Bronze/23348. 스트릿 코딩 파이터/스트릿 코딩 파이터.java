import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int c = in.nextInt();
        int t = in.nextInt();
        int max = -1;
        for (int i=0;i<t;i++){
            int total=0;
            for (int j=0;j<3;j++){
                int d = in.nextInt();
                int e = in.nextInt();
                int f = in.nextInt();
                total += a*d+b*e+c*f;
            }
            max = max>total?max:total;
        }
        System.out.println(max);
    }
}