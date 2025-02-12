import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int ans = 0;
        int[] aa = new int[a];
        for (int i=0;i<a;i++){
            aa[i] = in.nextInt();
        }
        for (int i=0;i<a;i++){
            int b = in.nextInt();
            int c = in.nextInt();
            if(aa[i]==1 && b<c){
                ans+=c-b;
            }
        }
        System.out.println(ans);
    }
}