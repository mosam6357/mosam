import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt(); int b=in.nextInt(); int c =in.nextInt(); int d=in.nextInt();
        if((a*d==64 || a*d==72 || a*d==81) && b==c){
            System.out.println("ignore");
        }
        else{
            System.out.println("answer");
        }
    }
}