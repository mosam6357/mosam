import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int c = in.nextInt();
        if(a+b<c*2){
            System.out.println(a+b);
        }
        else{
            System.out.println(a+b-c*2);
        }
    }
}