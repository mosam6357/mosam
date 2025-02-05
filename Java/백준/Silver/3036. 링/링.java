import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int[] aa = new int[a];
        for (int i=0;i<a;i++){
            aa[i] = in.nextInt();
        }
        for (int i=1;i<a;i++){
            int b = aa[0];
            int c = aa[i];
            int j = 2;
            while(true){
                if(b%j==0 && c%j==0){
                    b/=j;
                    c/=j;
                    j=1;
                }
                if(j>=b || j>=c){
                    break;
                }
                j++;
            }
            System.out.printf("%d/%d\n",b,c);
        }
    }
}