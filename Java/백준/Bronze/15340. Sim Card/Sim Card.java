import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        while(true){
            int a = in.nextInt();
            int b = in.nextInt();
            if (a==0 && b==0){
                break;
            }
            int min = 30*a+40*b;
            min = min<35*a+30*b?min:35*a+30*b;
            min = min<40*a+20*b?min:40*a+20*b;
            System.out.println(min);
        }
    }
}