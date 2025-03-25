import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        long k = in.nextInt();
        long n = in.nextInt();
        if (n==1){
            System.out.println("-1");
        }
        else{
            long x = (n*k)/(n-1);
            if ((x-k)*n>=x){
                System.out.println(x);
            }
            else{
                System.out.println(x+1);
            }
        }
    }
}