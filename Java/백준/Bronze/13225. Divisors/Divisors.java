import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i=0;i<a;i++){
            int n = in.nextInt();
            int cnt = 0;
            for (int j=1;j<=n;j++){
                if(n%j==0){cnt++;}
            }
            System.out.printf("%d %d\n",n,cnt);
        }
    }
}