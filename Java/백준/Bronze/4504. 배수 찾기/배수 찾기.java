import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        while(true){
            int b = in.nextInt();
            if (b==0){
                break;
            }
            if (b%a==0){
                System.out.printf("%d is a multiple of %d.\n",b,a);
            }
            else{
                System.out.printf("%d is NOT a multiple of %d.\n",b,a);
            }
        }
    }
}