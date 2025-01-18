import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int lim = in.nextInt();
        int n = in.nextInt();
        int cnt = 0;
        for (int i=0;i<n;i++){
            cnt += in.nextInt();
        }
        System.out.println((n+1)*lim-cnt);
    }
}