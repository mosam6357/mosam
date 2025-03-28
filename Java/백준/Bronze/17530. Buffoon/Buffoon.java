import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int m = b;
        for (int i=1;i<a;i++){
            int n = in.nextInt();
            m = m>n?m:n;
        }
        if (b==m){
            System.out.println("S");
        }
        else{
            System.out.println("N");
        }
    }
}