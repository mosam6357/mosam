import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        double a = in.nextDouble();
        double b = in.nextDouble();
        if(a>=b/2){
            System.out.println('E');
        }
        else{
            System.out.println('H');
        }
    }
}