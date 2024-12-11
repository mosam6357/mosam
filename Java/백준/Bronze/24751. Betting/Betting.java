import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        float a = in.nextFloat();
        float b = 100-a;
        System.out.println(100/a);
        System.out.println(100/b);
    }
}