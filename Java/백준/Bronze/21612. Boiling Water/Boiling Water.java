import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = a==100?0:(a>100?-1:1);
        System.out.println(a*5-400);
        System.out.println(b);
    }
}