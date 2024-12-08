import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int[] aa = new int[6];
        for (int i =0; i<6; i++){
            aa[i] = in.nextInt();
        }
        int b = in.nextInt();
        int c = in.nextInt();
        int sumt = 0; int sump =a/c; int p=a%c;
        for (int i=0; i<6; i++){
            sumt += aa[i]/b;
            if(aa[i]%b!=0){
                sumt+=1;
            }
        }
        System.out.printf("%d\n%d %d",sumt,sump,p);
    }
}