import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int c = in.nextInt();
        int min = a<b?a:b;
        min = min<c?min:c;
        System.out.println(a+b+c-min);
    }
}