import java.util.Scanner;
import java.util.Arrays;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int cnt = 0;
        int a = in.nextInt();
        int[] aa = new int[a];
        for (int i=0;i<a;i++){
            aa[i] = in.nextInt();
        }
        Arrays.sort(aa);
        for (int i=1;i<a;i++){
            if(aa[i]==aa[i-1]){
                cnt++;
            }
        }
        System.out.println(cnt);
    }
}