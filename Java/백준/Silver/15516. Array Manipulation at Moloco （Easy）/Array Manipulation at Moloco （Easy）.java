import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int[] aa = new int[a];
        for (int i=0;i<a;i++){
            aa[i] = in.nextInt();
            int cnt = 0;
            for (int j=0;j<i;j++){
                if(aa[i]>aa[j]){
                    cnt++;
                }
            }
            System.out.println(cnt);
        }
    }
}