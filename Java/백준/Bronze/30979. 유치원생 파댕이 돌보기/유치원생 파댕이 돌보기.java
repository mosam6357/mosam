import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int sum = 0;
        for (int i =0; i<b; i++){
            sum+=in.nextInt();
        }
        if(sum>=a){
            System.out.printf("Padaeng_i Happy");
        }
        else{
            System.out.printf("Padaeng_i Cry");
        }
    }
}