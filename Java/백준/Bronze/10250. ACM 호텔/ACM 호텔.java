import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int q = in.nextInt();
        for (int i =0; i<q; i++){
            int a = in.nextInt();
            int b = in.nextInt();
            int c = in.nextInt();
            int f = c%a;
            if(f==0){
                f=a;
            }
            int h = (c-1)/a+1;
            if(h<10){
                System.out.printf("%d0%d%n",f,h);
            }
            else{
                System.out.printf("%d%d%n",f,h);
            }
        }
    }
}