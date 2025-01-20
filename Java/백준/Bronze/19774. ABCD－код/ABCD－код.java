import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int t = in.nextInt();
        for (int i=0;i<t;i++){
            int n = in.nextInt();
            int a = n/1000;
            int b = n%1000/100;
            int c = n%100/10;
            int d = n%10;
            int p1 = a*10+b;
            p1*=p1;
            int p2 = c*10+d;
            p2*=p2;
            if((p1+p2)%7==1){
                System.out.println("YES");
            }
            else{
                System.out.println("NO");
            }
        }
    }
}