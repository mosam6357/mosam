import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] a = new int[5];
        int time =0;
        for (int i=0; i<5; i++){
            a[i] = in.nextInt();
        }
        while(a[0]<a[1]){
            if(a[0]<0){
                time+=a[2];
                a[0]++;
            }
            else if(a[0]==0){
                time+=a[3]+a[4];
                a[0]++;
            }
            else{
                time+=a[4];
                a[0]++;
            }
        }
        System.out.println(time);
    }
}