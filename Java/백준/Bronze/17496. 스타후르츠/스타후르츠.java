import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int c = in.nextInt();
        int d = in.nextInt();
        int total = 0;
        for (int i = b+1; i<a+1; i+=b){
            total += c*d;
        }
        System.out.println(total);
    }
}