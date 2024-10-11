import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] a = new int[5];
        for (int i =0; i<5; i++){
            a[i] = in.nextInt();
        }
        int s1 = a[0]-a[2]>0?a[0]-a[2]:a[2]-a[0];
        int s2 = a[1]-a[3]>0?a[1]-a[3]:a[3]-a[1];
        if(s1+s2>a[4] || (s1+s2)%2!=a[4]%2){
            System.out.println('N');
        }
        else{
            System.out.println('Y');
        }
    }
}