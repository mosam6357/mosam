import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a =in.nextInt();
        int b = in.nextInt();
        if(a==b){
            if(a==0){
                System.out.println("Not a moose");
            }
            else{
                System.out.printf("Even %d",a*2);
            }
        }
        else{
            int c = a>b?a:b;
            System.out.printf("Odd %d",c*2);
        }
    }
}