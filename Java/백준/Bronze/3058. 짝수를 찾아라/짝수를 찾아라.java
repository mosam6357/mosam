import java.util.Scanner;

public class Main{
    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        int t = in.nextInt();
        for (int i=0;i<t;i++){
            int sum=0;
            int min=101;
            for (int j=0;j<7;j++){
                int n = in.nextInt();
                if(n%2==0){
                    sum+=n;
                    min = min<n?min:n;
                }
            }
            System.out.printf("%d %d\n",sum,min);
        }
    }
}