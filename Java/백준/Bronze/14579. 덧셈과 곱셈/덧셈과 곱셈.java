import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int n = 1;
        for (int i=a;i<=b;i++){
            n*=(i*(i+1))/2;
            n%=14579;
        }
        System.out.println(n);
    }
}