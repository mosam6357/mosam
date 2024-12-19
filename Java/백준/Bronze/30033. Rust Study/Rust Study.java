import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int cnt = 0;
        int[] aa = new int[a];
        for (int i=0; i<a; i++){
            aa[i] = in.nextInt();
        }
        for (int i=0; i<a; i++){
            if (in.nextInt()>=aa[i]){
                cnt++;
            }
        }
        System.out.println(cnt);
    }
}