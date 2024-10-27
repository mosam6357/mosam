import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] a = new int[4];
        for (int i=0; i<4; i++){
            a[i] = in.nextInt();
        }
        if(a[1]<=a[2] || a[3]<=a[0]){
            System.out.println(a[1]-a[0]+a[3]-a[2]);
        }
        else{
            System.out.println((a[1]>a[3]?a[1]:a[3])-(a[0]<a[2]?a[0]:a[2]));
        }
    }
}