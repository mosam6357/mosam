import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int t = in.nextInt();
        for (int i=0;i<t;i++){
            int a = in.nextInt();
            int b = in.nextInt();
            System.out.printf("You get %d piece(s) and your dad gets %d piece(s).\n",a/b,a%b);
        }
    }
}