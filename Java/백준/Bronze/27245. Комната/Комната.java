import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int c = in.nextInt();
        int max = a>b?a:b;
        int min = a<b?a:b;
        if(min>=c*2 && max <= min*2){
            System.out.println("good");
        }
        else{
            System.out.println("bad");
        }
    }
}