import java.util.Scanner;

public class Main{
    static Scanner in = new Scanner(System.in);
    static int n = in.nextInt();
    static int m = in.nextInt();
    static StringBuilder sb = new StringBuilder();
    static int[] path = new int[m];
    public static void main(String[] args){
        permu(0,0);
        System.out.println(sb.toString());
    }
    public static void permu(int cnt,int min){
        if (cnt==m){
            for (int i=0;i<m;i++){
                sb.append(Integer.toString(path[i])+" ");
            }
            sb.append("\n");
            return;
        }
        for (int i=min;i<n;i++){
            path[cnt]=i+1;
            permu(cnt+1,i+1);
        }
    }
}