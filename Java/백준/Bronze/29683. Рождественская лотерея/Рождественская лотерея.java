import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int sum = 0;
        for (int i=0; i<a; i++){
            int c = in.nextInt();
            sum += c/b;
        }
        System.out.println(sum);
    }
}