import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int s = 0;
        int[] aa = new int[a];
        int[] bb = new int[a];
        for (int i=0;i<a;i++){
            aa[i] = in.nextInt();
        }
        for (int i=0;i<a;i++){
            bb[i] = in.nextInt();
        }
        for (int i=0;i<a;i++){
            if(aa[i]>bb[i]){s+=3;}
            else if(aa[i]==bb[i]){s++;}
        }
        System.out.println(s);
    }
}