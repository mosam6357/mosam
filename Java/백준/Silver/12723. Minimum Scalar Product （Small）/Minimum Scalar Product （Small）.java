import java.util.Scanner;
import java.util.Arrays;
import java.util.Collections;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        for (int i=0;i<a;i++){
            int ans = 0;
            int b = in.nextInt();
            int[] aa = new int[b];
            int[] bb = new int[b];
            int[] cc = new int[b];
            for (int j=0;j<b;j++){
                aa[j] = in.nextInt();
            }
            for (int j=0;j<b;j++){
                bb[j] = in.nextInt();
            }
            Arrays.sort(aa);
            Arrays.sort(bb);
            for (int j=0;j<b;j++){
                cc[j] = bb[b-j-1];
                ans+=aa[j]*cc[j];
            }
            System.out.printf("Case #%d: %d\n",i+1,ans);
        }
    }
}