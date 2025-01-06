import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int y = (b-2*a)/2;
        int x = a-y;
        System.out.printf("%d %d",x,y);
    }
}