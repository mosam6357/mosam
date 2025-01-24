import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int[] aa = new int[a];
        for (int i=0;i<a;i++){
            aa[i] = in.nextInt();
        }
        int max = 0;
        for (int i=0;i<a;i++){
            for (int j=i;j<a;j++){
                int x = aa[j]-aa[i];
                max = max>x?max:x;
            }
        }
        System.out.println(max);
    }
}