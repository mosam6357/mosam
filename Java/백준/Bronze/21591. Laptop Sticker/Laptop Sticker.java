import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt(); int b = in.nextInt();
        int c = in.nextInt(); int d = in.nextInt();
        if(a>c+1 && b>d+1){
            System.out.println(1);
        }
        else{
            System.out.println(0);
        }
    }
}