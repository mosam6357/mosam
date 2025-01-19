import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int n = in.nextInt();
        int cnt = 0;
        for (int i=0;i<n;i++){
            int t = in.nextInt();
            if(t>=a && t<=b)
                cnt++;
        }
        System.out.println(cnt);
    }
}