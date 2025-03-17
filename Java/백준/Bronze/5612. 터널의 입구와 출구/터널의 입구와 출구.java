import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int n = in.nextInt();
        int m = n;
        for (int i=0;i<a;i++){
            n = n+in.nextInt()-in.nextInt();
            if (n<0){
                m=0;
                break;
            }
            m = m>n?m:n;
        }
        System.out.println(m);
    }
}