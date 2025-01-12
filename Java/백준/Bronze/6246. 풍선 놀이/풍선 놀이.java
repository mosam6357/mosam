import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int a = in.nextInt();
        int[] aa = new int[n];
        int cnt = 0;
        for (int i=0;i<a;i++){
            int b = in.nextInt();
            int c = in.nextInt();
            for (int j=b-1;j<n;j+=c){
                aa[j] = 1;
            }
        }
        for (int i=0;i<n;i++){
            if(aa[i]==0){cnt++;}
        }
        System.out.println(cnt);
    }
}