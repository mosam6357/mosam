import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] a = new int[5];
        int max = 30000;
        int cnt = 0;
        for (int i=0; i<5; i++){
            a[i] = in.nextInt();
            max = max>a[i]?max:a[i];
        }
        for (int i =0; i<5; i++){
            if(a[i]!=max && max-a[i]<=1000){
                cnt++;
            }
        }
        System.out.println(cnt);
    }
}