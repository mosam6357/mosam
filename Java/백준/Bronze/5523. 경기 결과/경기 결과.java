import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int cnt1 = 0;
        int cnt2 = 0;
        for (int i=1;i<=a;i++){
            int n1 = in.nextInt();
            int n2 = in.nextInt();
            if (n1>n2){
                cnt1++;
            }
            else if(n1<n2){
                cnt2++;
            }
        }
        System.out.printf("%d %d",cnt1,cnt2);
    }
}