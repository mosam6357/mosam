import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i=1;i<=a;i++){
            double cost = in.nextDouble();
            System.out.printf("$%.2f\n",cost*0.8);
        }
    }
}