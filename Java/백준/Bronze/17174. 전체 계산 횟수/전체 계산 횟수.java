import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int total = a;
        while(a>=b){
            a/=b;
            total+=a;
        }
        System.out.println(total);
    }
}