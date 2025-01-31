import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        int[] aa = new int[10];
        for(int i=a;i<=b;i++){
            String s1 = Integer.toString(i);
            for (int j=0;j<s1.length();j++){
                aa[s1.charAt(j)-'0']++;
            }
        }
        for(int i=0;i<10;i++){
            System.out.printf("%d ",aa[i]);
        }
    }
}