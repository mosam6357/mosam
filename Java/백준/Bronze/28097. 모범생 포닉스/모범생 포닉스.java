import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int h = 8*(a-1);
        for (int i=0; i<a; i++){
            h += in.nextInt();
        }
        System.out.printf("%d %d",h/24,h%24);
    }
}