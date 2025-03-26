import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        long b = in.nextInt();
        long n = 1;
        for (int i=0;i<a;i++){
            long c = in.nextInt();
            n*=c%b;
            n=n%b;
        }
        System.out.println(n);
    }
}