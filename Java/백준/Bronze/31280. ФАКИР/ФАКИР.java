import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] a = new int[4];
        int sum = 0;
        int min = 500;
        for (int i =0; i<4; i++){
            a[i] = in.nextInt();
            sum+=a[i];
            min = min<a[i]?min:a[i];
        }
        System.out.println(sum-min+1);
    }
}