import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int n = in.nextInt(); int a = in.nextInt(); int b = in.nextInt(); int ck=1;
        if(n>b){
            ck=0;
        }
        if(b==a && ck==1){
            System.out.println("Anything");
        }
        else if(b<a && ck==1){
            System.out.println("Subway");
        }
        else{
            System.out.println("Bus");
        }
    }
}