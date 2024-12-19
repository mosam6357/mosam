import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int c = in.nextInt();
        b = b>a-b?b:a-b;
        c = c>a-c?c:a-c;
        System.out.println(b*c*4);
    }
}