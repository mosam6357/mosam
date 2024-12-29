import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int t = 10;
        int l = 1;
        while(a>t){
            if(a%t<=4*l){
                a-=a%t;
            }
            else{
                a=(a/t+1)*t;
            }
            t*=10;
            l*=10;
        }
        System.out.println(a);
    }
}