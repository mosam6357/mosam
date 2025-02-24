import java.util.Scanner;

public class Main{
    static Scanner in = new Scanner(System.in);
    static int n = in.nextInt();
    static int m = in.nextInt();
    static StringBuilder sb = new StringBuilder();
    static int[] used = new int[n];
    static int[] path = new int[m];
    public static void main(String[] args){
        permu(0);
        System.out.println(sb.toString());
    }
    public static void permu(int cnt){
        if (cnt==m){
            for (int i=0;i<m;i++){
                sb.append(String.format("%d ",path[i]));
            }
            sb.append("\n");
            return;
        }
        for (int i=0;i<n;i++){
            if (used[i]==0){
                path[cnt]=i+1;
                used[i]=1;
                permu(cnt+1);
                used[i]=0;
            }
        }
    }
}