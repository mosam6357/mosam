 import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int c = in.nextInt();
        if(b+c<60){
            int q = b+c;
            System.out.printf("%d %d",a,q);
        }
        else{
            int d = a+(b+c)/60;
            if(d<23){
                int w = (b+c)%60;
                System.out.printf("%d %d",d,w);
            }
            else{
                int w = (b+c)%60;
                System.out.printf("%d %d",d%24,w);
            }
        }
    }
}