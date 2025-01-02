import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int q = in.nextInt();
        for (int w=0;w<q;w++){
        int a = in.nextInt();
        int[] aa = new int[a];
        int[] bb = new int[a];
        int cnt = 0;
        for (int i=0;i<a;i++){
            aa[i]=in.nextInt();
        }
        for (int i=0;i<a;i++){
            bb[i] = in.nextInt();
        }
        for (int i=0;i<a;i++){
            if(aa[i]!=bb[i]){cnt++;}
        }
        System.out.println(cnt);
    }
    }
}