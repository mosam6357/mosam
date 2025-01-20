import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        while(true){
            int a = in.nextInt();
            int b = in.nextInt();
            int c = in.nextInt();
            if (a==0 && b==0 && c==0){
                break;
            }
            if(a==0){
                System.out.printf("%d %d %d\n",c/b,b,c);
            }
            else if(b==0){
                System.out.printf("%d %d %d\n",a,c/a,c);
            }
            else{
                System.out.printf("%d %d %d\n",a,b,a*b);
            }
        }
    }
}