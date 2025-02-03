import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int[] aa = new int[a];
        int[] bb = new int[a];
        for (int i=0;i<a;i++){
            aa[i] = in.nextInt();
            bb[i] = in.nextInt();
        }
        for (int i=0;i<a;i++){
            int s = 1;
            for (int j=0;j<a;j++){
                if(aa[i]<aa[j] && bb[i]<bb[j]){
                    s++;
                }
            }
            System.out.printf("%d ",s);
        }
    }
}