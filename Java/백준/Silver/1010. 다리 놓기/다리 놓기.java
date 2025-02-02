import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i=0;i<a;i++){
            int r = in.nextInt();
            int n = in.nextInt();
            long ans = 1;
            for (int j=0;j<r;j++){
                ans *= n-j;
                ans /= j+1;
            }
            System.out.println(ans);
        }
    }
}