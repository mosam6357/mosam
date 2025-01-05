import java.util.Scanner;
import java.lang.Math;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int t = in.nextInt();
        for (int i=0;i<t;i++){
            int[] aa = new int[6];
            for(int j=0;j<6;j++){
                aa[j] = in.nextInt();
            }
            System.out.println(Math.abs(aa[3]-aa[0])+Math.abs(aa[4]-aa[1])+aa[2]+aa[5]);
        }
    }
}