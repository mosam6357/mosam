import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int q = a+b;
        int w = a-b;
        System.out.println(q>w?q:w);
        System.out.println(q<w?q:w);
    }
}