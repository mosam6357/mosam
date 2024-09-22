import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i =0; i<a/5; i++){
            System.out.printf("V");
        }
        for (int j =0; j<a%5; j++){
            System.out.printf("I");
        }
    }
}