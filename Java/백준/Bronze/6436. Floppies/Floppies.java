import java.util.Scanner;
import java.lang.Math;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int i = 1;
        while(true){
            double a = in.nextDouble();
            if (a==0){
                break;
            }
            double b = Math.ceil(a/2480000);
            System.out.printf("File #%d\n",i);
            System.out.printf("John needs %.0f floppies.\n\n",b);
            i++;
        }
    }
}