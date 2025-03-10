import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i=0;i<a;i++){
            double p = in.nextDouble();
            double c = in.nextDouble();
            System.out.println(100*p/(c+100));
        }
    }
}