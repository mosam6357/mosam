import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        double s = 0;
        for (int i=0;i<a;i++){
            double q = in.nextDouble();
            double w = in.nextDouble();
            s+=q*w;
        }
        System.out.println(s);
    }
}