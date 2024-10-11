import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a=in.nextInt(); int b= in.nextInt();
        for (int i =0; i<a; i++){
            for (int j=0; j<b; j++){
                System.out.printf("*");
            }
            System.out.println();
        }
    }
}