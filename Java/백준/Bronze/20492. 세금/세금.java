import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        double a = in.nextDouble();
        double n1 = a*0.78;
        double n2 = a*0.956;
        System.out.printf("%.0f %.0f",n1,n2);
    }
}