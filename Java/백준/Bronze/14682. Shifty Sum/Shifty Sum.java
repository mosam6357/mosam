import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int n = a;
        for (int i=0;i<b;i++){
            n*=10;
            a+=n;
        }
        System.out.println(a);
    }
}