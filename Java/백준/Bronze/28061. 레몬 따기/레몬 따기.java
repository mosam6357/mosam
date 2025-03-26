import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int m =0;
        for (int i=0;i<a;i++){
            int n = in.nextInt()-(a-i);
            m = m>n?m:n;
        }
        System.out.println(m);
    }
}