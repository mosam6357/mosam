import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int a = in.nextInt();
        int[] aa = new int[n];
        for(int i=0; i<n; i++){
            aa[i] = in.nextInt();
        }
        int sum=0;
        for (int i=0; i<n; i++){
            for (int j=i+1; j<n-1; j++){
                for(int k=j+1; k<n; k++){
                    int b = aa[i]+aa[j]+aa[k];
                    sum = (b>sum && b<=a)?b:sum;
                }
            }
            if(sum==a){break;}
        }
        System.out.println(sum);
    }
}