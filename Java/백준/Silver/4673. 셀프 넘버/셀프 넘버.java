import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int[] aa = new int[10000];
        for (int i=1;i<=10000;i++){
            int n = i;
            String s = Integer.toString(i);
            for (int j=0;j<s.length();j++){
                n+= s.charAt(j)-'0';
            }
            if (n<=10000){
                aa[n-1] = 1;
            }
        }
        for (int i=0;i<10000;i++){
            if (aa[i]==0){
                System.out.println(i+1);
            }
        }
    }
}