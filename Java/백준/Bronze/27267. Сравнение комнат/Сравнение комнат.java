import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int c = in.nextInt();
        int d = in.nextInt();
        if(a*b>c*d){
            System.out.println('M');
        }
        else if(a*b==c*d){
            System.out.println('E');
        }
        else{
            System.out.println('P');
        }
    }
}