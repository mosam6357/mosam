import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i =0; i<a; i++){
            if(i%2==1){
                System.out.printf(" ");
            }
            for(int j =0; j<a; j++){
                System.out.printf("* ");
            }
            System.out.println();
        }
    }
}