import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i=0; i<a; i++){
            int b = in.nextInt();
            if(b%2==0){
                System.out.printf("%d is even\n",b);
            }
            else{
                System.out.printf("%d is odd\n",b);
            }
        }
    }
}