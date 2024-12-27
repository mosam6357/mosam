import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int a = in.nextInt();
        int b = in.nextInt();
        int[] cnt = new int[3];
        for (int i=1; i<n+1; i++){
            if (i%a==0 && i%b==0){
                cnt[2]++;
            }
            else if(i%a==0){
                cnt[0]++;
            }
            else if(i%b==0){
                cnt[1]++;
            }
        }
        for (int i=0; i<3;i++){
            System.out.printf("%d ",cnt[i]);
        }
    }
}