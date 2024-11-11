import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] a = new int[5];
        for(int i=0; i<5; i++){
            a[i] = in.nextInt();
        }
        if(a[0]+a[1]+a[2]+a[3]>=a[4]*4){
            System.out.println(0);
        }
        else{
            System.out.println(a[4]*4-(a[0]+a[1]+a[2]+a[3]));
        }
    }
}