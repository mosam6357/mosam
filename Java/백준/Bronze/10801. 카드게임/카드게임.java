import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] a = new int[10];
        int[] b = new int[10];
        int cnt = 0;
        for (int i=0;i<10;i++){
            a[i]=in.nextInt();
        }
        for (int i=0;i<10;i++){
            b[i]=in.nextInt();
        }
        for (int i=0;i<10;i++){
            if (a[i]>b[i]){cnt++;}
            else if (a[i]<b[i]){cnt--;}
        }
        if (cnt==0){
            System.out.println("D");
        }
        else{
            System.out.println((cnt>0)?"A":"B");
        }
    }
}