import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        long a = in.nextLong();
        long b = in.nextLong();
        if(a*b%2==1){
            System.out.println(a<b?a:b);
        }
        else{
            System.out.println(0);
        }
    }
}