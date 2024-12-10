import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        for (int i=0; i<3; i++){
            int[] a = new int[6];
            for (int j=0; j<6; j++){
                a[j] = in.nextInt();
            }
            int t1 = a[0]*3600+a[1]*60+a[2];
            int t2 = a[3]*3600+a[4]*60+a[5];
            int t = t2-t1;
            System.out.printf("%d %d %d\n",t/3600,(t%3600)/60,t%60);
        }
    }
}