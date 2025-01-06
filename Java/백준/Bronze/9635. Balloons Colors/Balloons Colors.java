import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int q = in.nextInt();
        for (int i=0;i<q;i++){
            int n = in.nextInt();
            int a = in.nextInt();
            int b = in.nextInt();
            int[] aa = new int[n];
            for (int j=0;j<n;j++){
                aa[j]=in.nextInt();
            }
            if(aa[0]==a && aa[n-1]==b){
                System.out.println("BOTH");
            }
            else if(aa[0]==a && aa[n-1]!=b){
                System.out.println("EASY");
            }
            else if(aa[0]!=a && aa[n-1]==b){
                System.out.println("HARD");
            }
            else{
                System.out.println("OKAY");
            }
        }
    }
}