import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        if (a%2==0){
            int b = a/2;
            if (b%2==0){
                System.out.println(2);
            }
            else{
                System.out.println(1);
            }
        }
        else{
            System.out.println(0);
        }
    }
}