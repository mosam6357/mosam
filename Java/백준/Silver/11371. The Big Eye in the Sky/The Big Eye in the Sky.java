import java.util.Scanner;
import java.lang.Math;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        while(true){
            double x = in.nextDouble();
            double y = in.nextDouble();
            if (x==0 && y==0){
                break;
            }
            if (x==0){
                System.out.println(90);
            }
            else{
                System.out.println(Math.round(180*Math.atan(y/x)/Math.PI));
            }
        }
    }
}