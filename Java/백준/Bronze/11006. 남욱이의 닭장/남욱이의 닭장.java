import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i=0; i<a; i++){
            int b=in.nextInt();int c = in.nextInt();
            int s = c*2-b;
            System.out.printf("%d %d\n",s,c-s);
        }
    }
}