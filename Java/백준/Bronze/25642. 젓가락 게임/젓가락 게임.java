import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        while(true){
            b+=a;
            if (b>=5){
                System.out.println("yt");
                break;
            }
            a+=b;
            if(a>=5){
                System.out.println("yj");
                break;
            }
        }
    }
}