import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] a = new int[3];
        for (int i =0; i<3 ;i++){
            a[i] = in.nextInt();
        }
        int sum=0;
        int max = a[0]>a[1]?a[0]:a[1];
        max = max>a[2]?max:a[2];
        for (int i=0; i<3; i++){
            sum+=max-a[i];
        }
        System.out.println(sum);
    }
}