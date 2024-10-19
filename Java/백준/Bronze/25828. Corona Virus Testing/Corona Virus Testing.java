import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int c = in.nextInt();
        int g = a+b*c;
        if(g==a*b){
            System.out.println(0);
        }
        else if(g>a*b){
            System.out.println(1);
        }
        else{
            System.out.println(2);
        }
    }
}