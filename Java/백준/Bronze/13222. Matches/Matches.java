import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int c = in.nextInt();
        for (int i=0;i<a;i++){
            int n = in.nextInt();
            if (n*n<=b*b+c*c){
                System.out.println("YES");
            }
            else{
                System.out.println("NO");
            }
        }
    }
}