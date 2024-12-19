import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int c = in.nextInt();
        if(a==b || b==c|| c==a||a+b==c||b+c==a||c+a==b){
            System.out.println("S");
        }
        else{
            System.out.println("N");
        }
    }
}