import java.util.Scanner;

public class Main{
    public static int gcd(int a,int b){
        if(b==0){
            return a;
        }
        return gcd(b,a%b);
    }
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        if(b>a){
            int temp = a;
            a = b;
            b = temp;
        }
        int d = gcd(a,b);
        int m = a*b/d;
        System.out.println(d);
        System.out.println(m);
    }
}