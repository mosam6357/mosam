import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int c = in.nextInt();
        int t = in.nextInt();
        for (int i=0;i<t;i++){
            int a = in.nextInt();
            int b = in.nextInt();
            if (c==a){
                c=b;
            }
            else if (c==b){
                c=a;
            }
        }
        System.out.println(c);
    }
}