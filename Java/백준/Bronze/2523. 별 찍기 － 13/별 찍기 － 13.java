import java.util.Scanner;
import java.lang.Math;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i=0;i<2*a-1;i++){
            for (int j=0;j<a-Math.abs(a-(i+1));j++){
                System.out.printf("*");
            }
            System.out.println();
        }
    }
}